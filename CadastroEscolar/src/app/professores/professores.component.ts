import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Professor } from '../models/Professor';

@Component({
  selector: 'app-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent implements OnInit {

  public modalRef?: BsModalRef;
  public profForm: FormGroup;
  public titulo = 'Professores';
  public professorSelecionado!: Professor;
  


  public professores = [
  {id: 1, nome: 'Carlos', disciplina:'Matemática' },
  {id: 2, nome: 'Ricardo', disciplina:'Quimica' },
  {id: 3, nome: 'Tiago', disciplina:'Física' },
  {id: 4, nome: 'Rubens', disciplina:'Português' },
  {id: 5, nome: 'Clara', disciplina:'Inglês' },
  {id: 6, nome: 'Isabela', disciplina:'História' },
  {id: 7, nome: 'Celia', disciplina:'Literatura' },
  ];

 
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder, 
              private modalService: BsModalService) { 
    this.criarForm();
  }

  ngOnInit() {
  }

  criarForm(){
    this.profForm = this.fb.group({
      nome: ['', Validators.required],
      disciplina: ['', Validators.required]
    });
  }

profSubmit() {
  console.log(this.profForm.value);
}

  professorSelect(professor: Professor) {
    this.professorSelecionado = professor;
    this.profForm.patchValue(professor);
  }

  voltar() {
    this.professorSelecionado = null;
  }


}
