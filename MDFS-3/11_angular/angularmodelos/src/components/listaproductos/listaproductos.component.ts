import { Component, OnInit } from '@angular/core';
import {Producto} from './../../app/models/productos';
@Component({
  selector: 'app-listaproductos',
  templateUrl: './listaproductos.component.html',
  styleUrls: ['./listaproductos.component.css']
})
export class ListaproductosComponent implements OnInit {

  public productos:Array<Producto>;
  constructor() { 
    this.productos = [
      new Producto(
      "Nike Air Jordan",
      "https://i.ebayimg.com/images/g/lEsAAOSwBJpc1MAN/s-l300.jpg",
      150
      ),
      new Producto(
      "New Balance 1530",
      "https://cdn.webshopapp.com/shops/164432/files/292835943/new-balance-m1530kgl-olive-grey-pink-made-in-uk.jpg",
      140
      ),
      new Producto(
      "J-Hayber Olimpo",
      "https://jhayber.com/documents/images/products/63638-850-1.jpg",
      60
      ),
      new Producto(
      "Vans",
      "https://media.vogue.es/photos/5cc75028fdc822a6611ff5bb/master/w_2700,c_limit/voguees_moda_tendencias_250218163.jpg",
      75
      )
      ];
  }

  ngOnInit(): void {
  }

}
