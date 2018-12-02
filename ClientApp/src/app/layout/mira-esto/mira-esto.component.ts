import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mira-esto',
  templateUrl: './mira-esto.component.html',
  styleUrls: ['./mira-esto.component.css']
})
export class MiraEstoComponent implements OnInit {
  test: string = 'Esto es una prueba';

  constructor() { }

  ngOnInit() {
  }

}
