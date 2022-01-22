object Form2: TForm2
  Left = 0
  Top = 0
  Caption = 'Form2'
  ClientHeight = 265
  ClientWidth = 537
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -16
  Font.Name = 'Tahoma'
  Font.Style = []
  FormStyle = fsMDIChild
  OldCreateOrder = False
  Visible = True
  OnClose = FormClose
  DesignSize = (
    537
    265)
  PixelsPerInch = 96
  TextHeight = 19
  object Task_1_RB: TRadioButton
    Left = 40
    Top = 24
    Width = 417
    Height = 57
    Caption = 
      #1054#1087#1088#1077#1076#1077#1083#1080#1090#1100', '#1088#1072#1074#1085#1099' '#1083#1080' '#1082#1086#1083#1080#1095#1077#1089#1090#1074#1072' '#1087#1086#1083#1086#1078#1080#1090#1077#1083#1100#1085#1099#1093' '#1080' '#1086#1090#1088#1080#1094#1072#1090#1077#1083#1100#1085#1099#1093' '#1095#1080 +
      #1089#1077#1083' '#1074' '#1082#1072#1078#1076#1086#1081' '#1089#1090#1088#1086#1082#1077'.'
    TabOrder = 0
    WordWrap = True
  end
  object Task_2_RB: TRadioButton
    Left = 40
    Top = 104
    Width = 465
    Height = 57
    Caption = 
      #1057#1092#1086#1088#1084#1080#1088#1086#1074#1072#1090#1100' '#1086#1076#1085#1086#1084#1077#1088#1085#1099#1081' '#1084#1072#1089#1089#1080#1074' '#1080#1079' '#1089#1091#1084#1084' '#1086#1090#1088#1080#1094#1072#1090#1077#1083#1100#1085#1099#1093' '#1101#1083#1077#1084#1077#1085#1090#1086#1074' '#1074 +
      ' '#1082#1072#1078#1076#1086#1081' '#1089#1090#1088#1086#1082#1077'.'
    TabOrder = 1
    WordWrap = True
  end
  object Button1: TButton
    Left = 72
    Top = 189
    Width = 105
    Height = 57
    Anchors = [akLeft, akBottom]
    Caption = 'Save'
    TabOrder = 2
    OnClick = Button1Click
    ExplicitTop = 204
  end
  object Button2: TButton
    Left = 352
    Top = 189
    Width = 105
    Height = 57
    Anchors = [akRight, akBottom]
    Caption = 'Close'
    TabOrder = 3
    OnClick = Button2Click
    ExplicitTop = 204
  end
end
