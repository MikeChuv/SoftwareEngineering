object Form3: TForm3
  Left = 0
  Top = 0
  Caption = 'Task'
  ClientHeight = 577
  ClientWidth = 913
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -19
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnClose = FormClose
  PixelsPerInch = 96
  TextHeight = 23
  object Label1: TLabel
    Left = 48
    Top = 288
    Width = 6
    Height = 23
  end
  object Task_name: TLabel
    Left = 32
    Top = 24
    Width = 713
    Height = 23
  end
  object SG1: TStringGrid
    Left = 416
    Top = 88
    Width = 441
    Height = 161
    FixedCols = 0
    FixedRows = 0
    Options = [goFixedVertLine, goFixedHorzLine, goVertLine, goHorzLine, goRangeSelect, goEditing]
    TabOrder = 0
  end
  object Rows_edit: TEdit
    Left = 32
    Top = 88
    Width = 137
    Height = 33
    TabOrder = 1
    Text = 'Rows'
    OnChange = Rows_editChange
  end
  object Colls_edit: TEdit
    Left = 32
    Top = 144
    Width = 137
    Height = 33
    TabOrder = 2
    Text = 'Colls'
    OnChange = Colls_editChange
  end
  object Button1: TButton
    Left = 680
    Top = 480
    Width = 121
    Height = 65
    Caption = 'Solve'
    TabOrder = 3
    OnClick = Button1Click
  end
  object SG2: TStringGrid
    Left = 416
    Top = 288
    Width = 441
    Height = 153
    ColCount = 1
    FixedCols = 0
    FixedRows = 0
    TabOrder = 4
  end
end
