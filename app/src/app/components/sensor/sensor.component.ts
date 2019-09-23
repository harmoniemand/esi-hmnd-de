import { Component, OnInit } from '@angular/core';
import { Subject, BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-sensor',
  templateUrl: './sensor.component.html',
  styleUrls: ['./sensor.component.scss']
})
export class SensorComponent implements OnInit {

  sensors: any = {
    battery: {
      enabled: false,
      available: (navigator as any).getBattery ? true : false,
      value: 0,
      subject: new BehaviorSubject<any>(null)
    },

    temperature: {
      enabled: false,
      available: false,
      value: 0,
      subject: new BehaviorSubject<any>(null)
    },

    ambientlight: {
      enabled: false,
      available: (window as any).AmbientLightSensor ? true : false,
      value: 0,
      subject: new BehaviorSubject<any>(null)
    },

    proximity: {
      enabled: false,
      available: "ProximitySensor" in window ? true : false,
      value: 0,
      subject: new BehaviorSubject<any>(null)
    }
  }

  batteryEnabled = false;
  batAvail = false;
  batLevel = 0;
  battery;

  constructor() { }

  ngOnInit() {
    this.sensors.battery.subject.subscribe(b => {
      if (b == null) { return; }
        this.sensors.battery.available = true;
        this.sensors.battery.value = b.level;
    });

  }

  getBatteryData() {
    if ((navigator as any).getBattery) {
      (navigator as any).getBattery().then(b => this.sensors.battery.subject.next(b));
    } else {
      console.log("no battery api found");
    }
  }

  getSensorData() {
    if (this.sensors.battery.enabled) { this.getBatteryData(); }
  }

  changeSensor(s: string) {
    let sensor = this.sensors[s];

    if (sensor.enabled !== true) { sensor.enabled = true; }
    else { sensor.enabled = false; }

    if (sensor.enabled) {
      this.getSensorData();
    }

    console.log(this.sensors);
  }

}
