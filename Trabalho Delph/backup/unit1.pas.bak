unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, ComCtrls,
  StdCtrls, ExtCtrls, Buttons, Grids;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Edit1: TEdit;
    Edit10: TEdit;
    Edit11: TEdit;
    Edit12: TEdit;
    Edit13: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Edit8: TEdit;
    Edit9: TEdit;
    Image1: TImage;
    Image2: TImage;
    Image3: TImage;
    Label1: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Label12: TLabel;
    Label13: TLabel;
    Label14: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    PageControl1: TPageControl;
    Panel2: TPanel;
    Panel3: TPanel;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    SpeedButton3: TSpeedButton;
    SpeedButton4: TSpeedButton;
    SpeedButton5: TSpeedButton;
    SpeedButton6: TSpeedButton;
    SpeedButton7: TSpeedButton;
    SpeedButton8: TSpeedButton;
    SpeedButton9: TSpeedButton;
    StatusBar1: TStatusBar;
    StringGrid1: TStringGrid;
    TabSheet1: TTabSheet;
    TabSheet2: TTabSheet;
    TabSheet3: TTabSheet;
    Timer1: TTimer;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Edit10Change(Sender: TObject);
    procedure Edit12Change(Sender: TObject);
    procedure Edit13Change(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure RadioButton1Change(Sender: TObject);
    procedure RadioButton2Change(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure SpeedButton3Click(Sender: TObject);
    procedure SpeedButton4Click(Sender: TObject);
    procedure SpeedButton5Click(Sender: TObject);
    procedure SpeedButton6Click(Sender: TObject);
    procedure SpeedButton7Click(Sender: TObject);
    procedure AbrirArquivo;
    Procedure AtualizarGrid ;
    procedure exibeprod(np:integer);
    procedure exibedados(n:integer) ;
    procedure exibe(nd:integer) ;
    procedure SpeedButton8Click(Sender: TObject);
    procedure SpeedButton9Click(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

  TReg = record
       prodt:string[40];
        Desc:string[50];
        fab:string[15];
        QTDEst:string[15];
        valor:string [20] ;

   end;

  Tlog = record
       Cdg:integer;
       Nm:string[15];
       Sn:string[10];
       Crg:string[20];


  end;

  Tvenda = record

       cpdt:integer;
       qtdvend:integer;
       cdp: string[10];
       prodt:string[40];
       valor: string [20] ;

  end;

var
  Form1: TForm1;

  Arqprod:File of Treg;
  regprod:Treg;

  ArqVenda:file of Tvenda;
  regVenda:Tvenda;

implementation

uses unit2 , unit3, UNIT4;

{$R *.lfm}

{ TForm1 }

Function QtdeRegistros: integer;
var n:integer;

    begin

    Seek (arqprod,0);
    n:=0;

      while(not eof (arqprod)) do

       begin
         n:=n+1;
         read(arqprod,regprod);

       end;

       result:=n;
   end;

  function QtddeRegistrosVendas: integer;//saber quantidade de registros
 var nrVendas:integer;
 begin
      Seek(ArqVenda,1);//posicionar o ponteiro
      nrVendas:=0;
      while(Not eof (ArqVenda))do //eof End Of File
      begin
           nrVendas:= nrVendas+1;
           Read(ArqVenda,regVenda);//le um registro
      end;

      Result:= nrVendas;
 end;


   procedure TForm1.AbrirArquivo;
begin
     AssignFile(Arqprod,'etq.dat');
     if FileExists('etq.dat') then
     begin
          reset(Arqprod);
     end
     else
         begin
           ReWrite(Arqprod);
           Write(Arqprod,Regprod);
         end;
         end;

      procedure AbrirArquivoVendas;
 begin
   AssignFile(ArqVenda, 'venda.dat');
   if FileExists('venda.dat')then
       begin
        Reset(ArqVenda);//abrir arquivo
       end
   else
       begin
         Rewrite(ArqVenda);//criar e abrir
         Write(ArqVenda,regVenda);//gravar
       end;
       end;

   Procedure Tform1.AtualizarGrid ;
     var lin:integer;
     begin
      lin:=0;
      while(not eof (arqvenda)) do
      begin
        lin:=lin+1;
        read(arqvenda,regvenda);

With stringgrid1 do

       begin
       rowcount:=lin+1;
       cells[0,lin]:=regvenda.prodt;
       cells[1,lin]:=regvenda.valor;
       cells[2,lin]:=edit9.text;
       cells[3,lin]:= Edit10.text ;
       cells[3,lin]:=datetostr(date);


       end;
      end;
     end;

procedure Tform1.exibedados(n:integer) ;
begin
   Seek(arqprod,n);
read(arqprod,regprod);
Label2.caption:= inttostr(n);
Edit1.Text:=regprod.prodt;
Edit2.Text:= regprod.Desc;
Edit3.Text:=regprod.fab ;
Edit4.text:=regprod.QTDEst;
Edit5.text:=regprod.Valor;

   end;

procedure Tform1.exibeprod(np:integer) ;
begin
   Seek(arqprod,np);
read(arqprod,regprod);
Label2.caption:= inttostr(np);
Edit1.Text:=regprod.prodt;
Edit2.Text:= regprod.Desc;
Edit3.Text:=regprod.fab ;
Edit4.text:=regprod.QTDEst;
Edit5.text:=regprod.Valor;

   end;


procedure Tform1.exibe(nd:integer) ;
begin
seek(arqvenda,nd);
read(arqvenda,regvenda);
Label9.caption:= inttostr(nd);
Edit7.Text:= regprod.prodt;
Edit8.Text:=regprod.valor ;

end;

procedure TForm1.SpeedButton8Click(Sender: TObject);
  var achou : boolean;
    np: integer;

Begin

  achou:= false;
  np:=0;
  seek(arqprod,0);
while(not eof(arqprod)) and (not(achou)) do

 Begin

  np:=np+1;
  read(arqprod,regprod);
  achou:= (regprod.prodt=edit1.text);
  end;
if (achou) then exibedados(np)
else
 showmessage('registro não encontrado!');

end;

procedure TForm1.SpeedButton9Click(Sender: TObject);
  var achou : boolean;
     np: integer;
begin

Form4.listbox1.clear;
seek(arqPROD,1);
While(not eof (arqPROD)) do

          begin
          read(arqPROD,regPROD);
          if(regPROD.fab=edit3.text) then
          form4.listbox1.items.add(regPROD.PRODT);
end;
   form4.showmodal;
   end;

procedure TForm1.Edit12Change(Sender: TObject);
begin

end;

procedure TForm1.Button1Click(Sender: TObject);
begin
  edit6.clear;
   edit7.clear;
   edit8.clear;
   edit9.clear;
   edit10.clear;
   label9.Caption:=inttostr(QtddeRegistrosVendas);
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
  if ((edit7.text<>'') and (edit10.text<>'')) then
     begin
       regvenda.cpdt:=(strtoint(label9.caption)) ;
       regvenda.cdp:=Edit6.text;
       regvenda.prodt:=edit7.text;
       regvenda.valor:=edit8.text;
       regvenda.qtdvend:=(strtoint(edit10.text));

       seek(arqprod,strtoint(label9.caption));
       write(arqvenda,regvenda);   //gravar venda .

       showmessage('venda realizada com sucesso')
     end
  else
   begin
     showmessage('preencha os campos!');
     edit7.setfocus;
     end;
      AtualizarGrid ;
end;

procedure TForm1.Edit10Change(Sender: TObject);
begin
  Edit10.Text:= FloatToStr((StrToFloat(Edit8.Text) * (strtofloat(edit9.text))));
  // para calcular dois edit's automaticamente .
end;

procedure TForm1.Edit13Change(Sender: TObject);
begin

end;

procedure TForm1.RadioButton1Change(Sender: TObject);
begin
  edit11.Clear;
end;

procedure TForm1.RadioButton2Change(Sender: TObject);
begin
  edit12.Clear;
end;

procedure TForm1.SpeedButton1Click(Sender: TObject);
  var nd:integer;
 begin
    nd:=strtoint (edit6.text);
  if(nd<0)or(nd>qtderegistros)then showmessage('Registro inexistente!')
  else

   exibe(nd); // procurar por código do produto .

 end;

procedure TForm1.SpeedButton2Click(Sender: TObject);
  var achou : boolean;
nd: integer;

  Begin
    achou:= false;
    nd:=0;
    seek(arqPROD,0);
  while(not eof(arqPROD)) and (not(achou)) do

   Begin

    nd:=nd+1;
    read(arqPROD,regPROD);
    achou:= (regprod.prodt=edit1.text);
    end;
  if (achou) then exibedados(nd)
  else
   showmessage('registro não encontrado!');   //PROCURAR POR NOME.

end;

procedure TForm1.SpeedButton3Click(Sender: TObject);
begin



Form3.ShowModal;

end  ;

procedure TForm1.SpeedButton4Click(Sender: TObject);
begin
  close;
end;



procedure TForm1.Timer1Timer(Sender: TObject);
begin
  StatusBar1.Panels[2].Text:=datetostr(date);
  statusbar1.Panels[3].Text:=timetostr(time);
  StatusBar1.panels[1].Text:= Form2.Edit1.Text;
  StatusBar1.panels[0].Text:= reglog.crg;
end;

procedure TForm1.FormShow(Sender: TObject);
begin
  Form2.ShowModal;
  AbrirArquivo;
  AtualizarGrid ;
  AbrirArquivoVendas;
  RadioButton1.Checked:=true;

   form1.WindowState := wsMaximized;
   form1.Enabled := False;
   Form1.ShowModal;


   ShowMessage('Bem Vindo'+' '+Form2.Edit1.Text);

end;

procedure TForm1.SpeedButton5Click(Sender: TObject);
begin
   edit1.clear;
   edit2.clear;
   edit3.clear;
   edit4.clear;
   edit5.clear;
   label2.Caption:=inttostr(QtdeRegistros);
   //para limpar e criar um novo registro .
end;

procedure TForm1.SpeedButton6Click(Sender: TObject);
begin
  if(edit1.text<>'') then
     begin

       regprod.Prodt:=Edit1.text;
       regprod.Desc:=edit2.text;
       regprod.Fab:=edit3.text;
       regprod.QTDEst:=edit4.text;
       regprod.Valor:=edit5.text;
       seek(arqprod,strtoint(label2.caption));
       write(arqprod,regprod);
       showmessage('registro gravado com sucesso') ;
       //salvar registro .


   END;
end;

procedure TForm1.SpeedButton7Click(Sender: TObject);
var np:integer;
begin
   np:=strtoint (edit13.text);
 if(np<0)or(np>QtdeRegistros)then showmessage('Registro inexistente!')
 else

  exibedados(np);
 // procurar por código do produto .

end;

end.

