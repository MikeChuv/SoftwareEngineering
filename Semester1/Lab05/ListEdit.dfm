object FormListEdit: TFormListEdit
  Left = 0
  Top = 0
  Caption = #1056#1077#1076#1072#1082#1090#1080#1088#1086#1074#1072#1085#1080#1077' '#1089#1087#1080#1089#1082#1072
  ClientHeight = 231
  ClientWidth = 505
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -15
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnClose = FormClose
  PixelsPerInch = 96
  TextHeight = 18
  object NextBtn: TButton
    Left = 368
    Top = 120
    Width = 75
    Height = 25
    Caption = 'Next'
    TabOrder = 0
    OnClick = NextBtnClick
  end
  object PrevBtn: TButton
    Left = 272
    Top = 120
    Width = 75
    Height = 25
    Caption = 'Previous'
    TabOrder = 1
    OnClick = PrevBtnClick
  end
  object ZooEdit: TLabeledEdit
    Left = 24
    Top = 40
    Width = 121
    Height = 26
    EditLabel.Width = 55
    EditLabel.Height = 18
    EditLabel.Caption = #1047#1086#1086#1087#1072#1088#1082
    TabOrder = 2
  end
  object SpeciesEdit: TLabeledEdit
    Left = 176
    Top = 40
    Width = 129
    Height = 26
    EditLabel.Width = 91
    EditLabel.Height = 18
    EditLabel.Caption = #1050#1086#1083'-'#1074#1086' '#1074#1080#1076#1086#1074
    TabOrder = 3
  end
  object UniqueSpeciesEdit: TLabeledEdit
    Left = 322
    Top = 40
    Width = 121
    Height = 26
    EditLabel.Width = 98
    EditLabel.Height = 18
    EditLabel.Caption = #1050#1086#1083'-'#1074#1086' '#1088#1077#1076#1082#1080#1093
    TabOrder = 4
  end
  object DeleteBtn: TButton
    Left = 24
    Top = 152
    Width = 75
    Height = 25
    Caption = 'Delete'
    TabOrder = 5
    OnClick = DeleteBtnClick
  end
  object ChangeBtn: TButton
    Left = 136
    Top = 152
    Width = 75
    Height = 25
    Caption = 'Change'
    TabOrder = 6
    OnClick = ChangeBtnClick
  end
end
