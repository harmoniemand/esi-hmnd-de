import { Component, OnInit } from '@angular/core';
import * as L from 'leaflet';
// import * as HeatmapOverlay from './../../heatmap-plugin';
import * as uuid from 'uuid/v4';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { SignalRService } from 'src/app/services/signal-r.service';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.scss']
})
export class MapComponent implements OnInit {

  map: any;

  gateways: any[] = [];
  sensors: any[] = [];
  data: any[] = [];
  location: Subject<Position> = new Subject<Position>();

  constructor(
    public signalRService: SignalRService,
    private http: HttpClient) { }

  ngOnInit() {

    this.signalRService.startConnection();
    this.signalRService.addTransferChartDataListener();

    this.loadData();
    this.loadMap();
  }

  loadData() {
    this.http.get<any[]>(environment.api.baseUrl + 'LoraGateway').subscribe(result => {
      this.gateways = result;
      this.gateways.forEach(s => this.addGateway(s));
    });

    this.http.get<any[]>(environment.api.baseUrl + 'Sensor').subscribe(result => {
      console.log(result);
      this.sensors = result;
      this.sensors.forEach(s => this.addSensor(s));
    });

    this.signalRService.last.subscribe(d => {



      if (this.data.length > 15) {
        this.data.shift();
        this.data.pop();
        this.data.shift();
      }

      this.data.push({
        id: this.sensors[Math.floor(Math.random() * (this.sensors.length - 1))].id,
        time: Date.now(),
        value: d
      });

    })
  }

  loadMap() {
    this.map = L.map('mapid').setView([49.14802936671947, 9.20585632324219], 13);

    L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiaGFybW9uaWVtYW5kIiwiYSI6ImNqYnMweG9rOTB5NGwycW1mZ3M1M3g2bGkifQ.BWxSwxb35Ed-MfVNkquz2w', {
      attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>, Imagery © <a href="https://www.mapbox.com/">Mapbox</a>',
      maxZoom: 18,
      id: 'mapbox.streets',
      accessToken: 'pk.eyJ1IjoiaGFybW9uaWVtYW5kIiwiYSI6ImNqYnMweG9rOTB5NGwycW1mZ3M1M3g2bGkifQ.BWxSwxb35Ed-MfVNkquz2w'
    }).addTo(this.map);

    this.map.on('click', this.onMapClick);

    this.location.subscribe(pos => {
      this.map.panTo(new L.LatLng(pos.coords.latitude, pos.coords.longitude));
    });
    this.getLocation();

  }

  addSensor(sensor: any) {
    sensor.circle = L.circle([sensor.lat, sensor.long], {
      color: 'red',
      fillColor: '#f03',
      fillOpacity: 0.5,
      radius: 50
    }).addTo(this.map);
  }

  addGateway(gateway: any) {
    gateway.radius = L.circle([gateway.lat, gateway.long], {
      color: '#00f',
      fillColor: '#00f',
      fillOpacity: 0.05,
      radius: 5000
    }).addTo(this.map);

    gateway.point = L.circle([gateway.lat, gateway.long], {
      color: '#00f',
      fillColor: '#00f',
      fillOpacity: 0.05,
      radius: 50
    }).addTo(this.map);
  }

  getLocation() {
    if (navigator.geolocation) {
      navigator.geolocation.getCurrentPosition(pos => { this.location.next(pos); });
    } else {
      this.location = {
        coords: {
          accuracy: 1,
          altitude: null,
          altitudeAccuracy: null,
          heading: null,
          latitude: 49.1433171,
          longitude: 9.2143918,
          speed: null,
        },
        timestamp: (new Date).getTime()
      }
    }
  }

  onMapClick(e) {
    console.log(e.latlng);
  }

}
