import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MapComponent } from './components/map/map.component';


const routes: Routes = [
  // { path: 'login', component: LoginComponent },
  // { path: 'register', component: RegisterComponent },

  {
    path: '',
    redirectTo: '/map',
    pathMatch: 'full'
  },
  
  { path: 'map', component: MapComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
