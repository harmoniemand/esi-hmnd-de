import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MapComponent } from './components/map/map.component';
import { IndexComponent } from './components/index/index.component';
import { SensorsComponent } from './components/sensors/sensors.component';
import { SensorComponent } from './components/sensor/sensor.component';


const routes: Routes = [
  // { path: 'login', component: LoginComponent },
  // { path: 'register', component: RegisterComponent },

  {
    path: '',
    redirectTo: '/map',
    pathMatch: 'full'
  },
  
  { path: 'map', component: MapComponent },
  { path: 'index', component: IndexComponent },
  { path: 'sensors', component: SensorsComponent },
  { path: 'sensors/sense', component: SensorComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {useHash: true})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
