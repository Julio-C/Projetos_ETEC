unit Unit3;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls, Buttons;

type

  { TForm3 }

  TForm3 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Image1: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Panel1: TPanel;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    SpeedButton3: TSpeedButton;
    SpeedButton4: TSpeedButton;
    procedure exibelogin(nl:integer) ;
    procedure Abrirlog;
    procedure FormShow(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure SpeedButton3Click(Sender: TObject);
    procedure SpeedButton4Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

   Tlog = record

       Nm:string[15];
       Sn:string[10];
       Crg:string[20];
      end;

var
  Form3: TForm3;

   arqlog:file of Tlog;
   reglog: Tlog;

implementation
   uses unit1,Unit2;

   {$R *.lfm}

{ TForm3 }

Function qtdlogin : integer;  //quantidade de registros
var nl:integer;

begin

seek(arqlog,1);
    nl:=0;
    while(not eof(arqlog)) do

begin
 nl :=nl+1;
 read(arqlog,reglog); // le arquivo

end;

    result:= nl;

 end;

   procedure tform3.Abrirlog;
     begin
       AssignFile(arqlog,'log.dat');
       if FileExists('log.dat')then
           begin
            Reset(arqlog);//abrir arquivo
           end
       else
           begin
             Rewrite(arqlog);//criar e abrir
             Write(arqlog,reglog);//gravar
           end;

     end;

procedure TForm3.FormShow(Sender: TObject);
begin
   Abrirlog;
   begin
   Form1.Destroy;
end;


end;


  procedure Tform3.exibelogin(nl:integer) ;
begin
   Seek(arqlog,nl);
read(arqlog,reglog);
Label2.caption:= inttostr(nl);
Edit1.Text:= reglog.Nm;
Edit2.Text:=reglog.Sn ;
edit3.text:=reglog.crg;
end;

procedure TForm3.SpeedButton1Click(Sender: TObject);
begin    // novo

    Edit1.Clear;
    Edit2.Clear;
    Edit3.Clear;
    label2.Caption:=inttostr(qtdlogin);

end;

procedure TForm3.SpeedButton2Click(Sender: TObject);
begin      //salvar
   If ((Edit1.text<>'')and(Edit2.Text<>'')and(Edit3.Text<>''))then
        Begin
        reglog.Nm:=Edit1.Text;
        reglog.Sn:=Edit2.Text;
        reglog.Crg:=Edit3.Text;
        Seek(Arqlog,StrToInt(Label2.Caption));//posiciona no N° do registro
         Write(Arqlog,reglog);//grava
         ShowMessage ('Registro gravado com  sucesso!');
        end
         Else
            ShowMessage ('Preencha todos os campos');
end;

procedure TForm3.SpeedButton3Click(Sender: TObject);
var nl:integer;
begin
   nl:=strtoint (edit4.text);
 if(nl<0)or(nl>qtdlogin)then showmessage('Registro inexistente!')
 else

 exibelogin(nl);
 // procurar por código do produto .
end;

procedure TForm3.SpeedButton4Click(Sender: TObject);
begin

 edit1.Clear;
 edit2.clear;
 edit3.clear;

end;

end.

