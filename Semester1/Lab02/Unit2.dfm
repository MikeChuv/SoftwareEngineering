object Form2: TForm2
  Left = 0
  Top = 0
  Caption = 'Form2'
  ClientHeight = 365
  ClientWidth = 745
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
  object Button1: TButton
    Left = 80
    Top = 264
    Width = 113
    Height = 57
    Caption = 'OK'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 496
    Top = 264
    Width = 105
    Height = 57
    Caption = 'Cancel'
    TabOrder = 1
    OnClick = Button2Click
  end
  object Task_1_RB: TRadioButton
    Left = 544
    Top = 71
    Width = 145
    Height = 17
    Caption = 'Task 1'
    TabOrder = 2
  end
  object Task_2_RB: TRadioButton
    Left = 544
    Top = 104
    Width = 137
    Height = 17
    Caption = 'Task 2'
    TabOrder = 3
  end
end
