object Form3: TForm3
  Left = 0
  Top = 0
  Caption = 'Form3'
  ClientHeight = 419
  ClientWidth = 573
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -16
  Font.Name = 'Tahoma'
  Font.Style = []
  FormStyle = fsMDIChild
  Menu = MainMenu1
  OldCreateOrder = False
  Visible = True
  OnClose = FormClose
  PixelsPerInch = 96
  TextHeight = 19
  object Task_name: TLabel
    Left = 56
    Top = 16
    Width = 481
    Height = 49
    Alignment = taCenter
    AutoSize = False
    WordWrap = True
  end
  object SG1: TStringGrid
    Left = 257
    Top = 88
    Width = 280
    Height = 169
    FixedCols = 0
    FixedRows = 0
    Options = [goFixedVertLine, goFixedHorzLine, goVertLine, goHorzLine, goRangeSelect, goEditing]
    TabOrder = 0
  end
  object Rows_edit: TEdit
    Left = 48
    Top = 104
    Width = 121
    Height = 27
    TabOrder = 1
    Text = 'Rows'
    OnChange = Rows_editChange
  end
  object Colls_edit: TEdit
    Left = 48
    Top = 153
    Width = 121
    Height = 27
    TabOrder = 2
    Text = 'Colls'
    OnChange = Colls_editChange
  end
  object SG2: TStringGrid
    Left = 257
    Top = 263
    Width = 176
    Height = 138
    ColCount = 1
    FixedCols = 0
    RowCount = 1
    FixedRows = 0
    TabOrder = 3
  end
  object Button1: TButton
    Left = 48
    Top = 303
    Width = 121
    Height = 49
    Caption = 'Solve'
    TabOrder = 4
    OnClick = Button1Click
  end
  object MainMenu1: TMainMenu
    Left = 480
    Top = 360
    object Processing1: TMenuItem
      Caption = 'Processing'
      GroupIndex = 25
      object Solve1: TMenuItem
        Caption = 'Solve'
        OnClick = Button1Click
      end
    end
  end
end
