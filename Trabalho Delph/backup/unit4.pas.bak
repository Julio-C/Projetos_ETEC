unit Unit4;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls;

type

  { TForm4 }

  TForm4 = class(TForm)
    Button1: TButton;
    ListBox1: TListBox;
    procedure Button1Click(Sender: TObject);
    procedure ListBox1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }

  end;

var
  Form4: TForm4;

implementation
  USES UNIT1,unit2,unit3;
{$R *.lfm}

{ TForm4 }

procedure TForm4.Button1Click(Sender: TObject);
begin
  close;
end;

procedure TForm4.ListBox1Click(Sender: TObject);
begin
   form1.edit1.text:= listbox1.GetSelectedText;
  form1.speedbutton9click(form4);
end;

end.

