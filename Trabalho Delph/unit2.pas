unit Unit2;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  Buttons, ExtCtrls;

type

  { TForm2 }

  TForm2 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    Image1: TImage;
    Label1: TLabel;
    Label2: TLabel;
    SpeedButton2: TSpeedButton;
   procedure Edit1KeyPress(Sender: TObject; var Key: char);
    procedure Edit2Change(Sender: TObject);
    procedure Edit2KeyPress(Sender: TObject; var Key: char);
    procedure FormShow(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);

  private
    tentativas: Smallint;

    { private declarations }
  public
    { public declarations }
     procedure log(nm, sn : String);


  end;

    Tlog = record

       Nm:string[15];
       Sn:string[10];
       Crg:string[20];
      end;


var
  Form2: TForm2;
    arqlog:file of Tlog;
   reglog: Tlog;

implementation
 uses unit1,unit3,unit4;

 procedure TForm2.log (nm, sn: String);
    begin
      // Função para verificar login e senha
      // Verifica se o login for válido
      if ((nm=sn)) then
      begin
        form1.Enabled := True;  // Ativa o Form Principal
        Form2.Hide;  // Esconde o form de login
      end
      else
      begin
        ShowMessage('Usuário e/ou Senha não confere...');
        Edit1.SetFocus;
      end;
    end;

{ TForm2 }
{$R *.lfm}

procedure TForm2.Edit1KeyPress(Sender: TObject; var Key: char);
begin
  if (key = #13) then
   begin
     key := #0;
     Edit2.SetFocus;
   end;
end;

procedure TForm2.Edit2Change(Sender: TObject);
begin

end;

procedure TForm2.Edit2KeyPress(Sender: TObject; var Key: char);
begin
   if (key = #13) then
   begin
     key := #0;
     log (Edit1.Text, Edit2.Text); // Chama a procedure de login
   end;
end;


procedure TForm2.FormShow(Sender: TObject);
begin
 form1.showmodal;

end;


procedure TForm2.SpeedButton2Click(Sender: TObject);
begin
  application.terminate;
  ShowMessage('feche o sistema');
end;

end.

