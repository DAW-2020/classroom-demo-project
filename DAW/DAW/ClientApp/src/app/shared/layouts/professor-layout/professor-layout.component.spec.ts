import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ProfessorLayoutComponent } from './professor-layout.component';

describe('ProfessorLayoutComponent', () => {
  let component: ProfessorLayoutComponent;
  let fixture: ComponentFixture<ProfessorLayoutComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProfessorLayoutComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProfessorLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
