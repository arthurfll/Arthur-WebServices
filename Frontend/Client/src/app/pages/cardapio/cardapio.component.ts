import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { NavbarComponent } from '../../shared/navbar/navbar.component';
import { CardapioService } from '../../services/cardapio.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-cardapio',
  standalone: true,
  imports: [CommonModule,RouterModule],
  templateUrl: './cardapio.component.html',
  styleUrl: './cardapio.component.css'
})

export class CardapioComponent implements OnInit {
  itens: any[] = []

  constructor(private cardapioService: CardapioService) {}

  ngOnInit(): void {
    this.carregarItens()
  }

  carregarItens() {
    this.cardapioService.getCardapio().subscribe(data => {
      console.log(this.itens);
      this.itens = data
      console.log(data)
    })
  }
}
