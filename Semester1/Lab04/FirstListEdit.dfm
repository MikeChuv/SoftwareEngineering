object FormListInput: TFormListInput
  Left = 0
  Top = 0
  Caption = #1060#1086#1088#1084#1080#1088#1086#1074#1072#1085#1080#1077' '#1089#1087#1080#1089#1082#1072
  ClientHeight = 231
  ClientWidth = 593
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnClose = FormClose
  PixelsPerInch = 96
  TextHeight = 13
  object SpeciesEdit: TLabeledEdit
    Left = 168
    Top = 86
    Width = 121
    Height = 33
    EditLabel.Width = 69
    EditLabel.Height = 13
    EditLabel.Caption = #1050#1086#1083'-'#1074#1086' '#1074#1080#1076#1086#1074
    TabOrder = 0
  end
  object UniqueSpeciesEdit: TLabeledEdit
    Left = 320
    Top = 86
    Width = 121
    Height = 33
    EditLabel.Width = 109
    EditLabel.Height = 13
    EditLabel.Caption = #1050#1086#1083'-'#1074#1086' '#1088#1077#1076#1082#1080#1093' '#1074#1080#1076#1086#1074
    TabOrder = 1
  end
  object InputBtn: TButton
    Left = 456
    Top = 86
    Width = 105
    Height = 35
    Caption = #1042#1074#1086#1076
    TabOrder = 2
    OnClick = InputBtnClick
  end
  object ZooEdit: TLabeledEdit
    Left = 16
    Top = 86
    Width = 121
    Height = 33
    EditLabel.Width = 42
    EditLabel.Height = 13
    EditLabel.Caption = #1047#1086#1086#1087#1072#1088#1082
    TabOrder = 3
  end
end
