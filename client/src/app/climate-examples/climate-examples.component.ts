import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-climate-examples',
  templateUrl: './climate-examples.component.html',
  styleUrls: ['./climate-examples.component.css'],
})
export class ClimateExamplesComponent implements OnInit {
  exampleList = [
    {
      climateName: 'Beispiel1',
      globalRadiation: 67,
      outTemp: 6,
      outCoefficient: 45,
      inTemp: 44,
      inCoefficient: 7,
    },
    {
      climateName: 'Beispiel2',
      globalRadiation: 6,
      outTemp: 99,
      outCoefficient: 5,
      inTemp: 94,
      inCoefficient: 72,
    },
    {
      climateName: 'Beispiel3',
      globalRadiation: 27,
      outTemp: 46,
      outCoefficient: 40,
      inTemp: 94,
      inCoefficient: -2,
    },
  ];

  constructor() {}

  ngOnInit(): void {}
}
