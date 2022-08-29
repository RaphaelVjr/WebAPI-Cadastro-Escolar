import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Professor } from '../models/Professor';
import { ProfessorService } from './professor.service';

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
  public modo: string;
  


  public professores: Professor[];

 
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder, 
              private modalService: BsModalService,
              private professorService: ProfessorService) { 
    this.criarForm();
  }

  ngOnInit() {
    this.carregarProfessores();
  }


  carregarProfessores() {
    this.professorService.getAll().subscribe(
      (professores: Professor[]) => {
        this.professores = professores;
      },
      (erro: any) => {
        console.error(erro);
      }
    );
  }

  criarForm(){
    this.profForm = this.fb.group({
      nome: ['', Validators.required],
      disciplina: ['', Validators.required]
    });
  }

  salvarProfessor(professor: Professor) {
  (professor.id !== 0) ? this.modo = 'put' : this.modo = 'post';

    this.professorService[this.modo](professor).subscribe(
      (retorno: Professor) => {
        console.log(retorno);
        this.carregarProfessores();
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

profSubmit() {
  console.log(this.profForm.value);
}

  professorSelect(professor: Professor) {
    this.professorSelecionado = professor;
    this.profForm.patchValue(professor);
  }

  professorNovo() {
    this.professorSelecionado = new Professor();
    this.profForm.patchValue(this.professorSelecionado);
  }

  voltar() {
    this.professorSelecionado = null;
  }


}
