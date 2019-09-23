import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Station } from '../models/station';
import { HttpClient } from '@angular/common/http';
import { SignalRService } from './signal-r.service';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SensorService {

  private sensorHub: signalR.HubConnection; 

  public startConnection() {
    this.sensorHub = new signalR.HubConnectionBuilder()
                            .withUrl('https://localhost:5001/sensorvalues')
                            .build();
 
    this.sensorHub
      .start()
      .then(() => console.log('Connection started'))
      .catch(err => console.log('Error while starting connection: ' + err))
  }

  public stations: BehaviorSubject<Station[]> = new BehaviorSubject<Station[]>([]);

  constructor(
    public signalRService: SignalRService,
    private http: HttpClient
  ) {
    this.http.get<Station[]>(environment.api.baseUrl + 'Sensor').subscribe(result => {
      this.stations.next(result);
    });


    this.signalRService.last.subscribe(d => {
      this.data.push({
        id: this.sensors[Math.floor(Math.random() * (this.sensors.length - 1))].id,
        time: Date.now(),
        value: d
      });

    })
  }


}
