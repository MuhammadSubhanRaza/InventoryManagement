import { Component, OnInit } from '@angular/core';
import * as Chart from 'chart.js';

@Component({
  selector: 'app-user-dashboard',
  templateUrl: './user-dashboard.component.html',
  styleUrls: ['./user-dashboard.component.css']
})
export class UserDashboardComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    this.loadChart()
  }


  
  loadChart()
  {

    const myChart = new Chart("myChart", {
      type: 'bar',
      data: {
          labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
          datasets: [{
              label: '# of Votes',
              data: [12, 19, 3, 5, 2, 3],
              backgroundColor: [
                'rgb(255, 188, 18)',
                'rgb(255, 188, 18)',
                'rgb(255, 188, 18)',
                'rgb(255, 188, 18)',
                'rgb(255, 188, 18)',
                'rgb(255, 188, 18)',
              ],
              borderWidth: 1
          }]
      },
      options: {
          scales: {
              
          }
      }
  });    

  }

}
