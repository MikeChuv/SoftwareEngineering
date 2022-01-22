object FormTask: TFormTask
  Left = 0
  Top = 0
  Caption = #1056#1077#1096#1077#1085#1080#1077' '#1079#1072#1076#1072#1095#1080
  ClientHeight = 424
  ClientWidth = 743
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -19
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnClose = FormClose
  DesignSize = (
    743
    424)
  PixelsPerInch = 96
  TextHeight = 23
  object TaskSelectRG: TRadioGroup
    Left = 24
    Top = 24
    Width = 345
    Height = 105
    Caption = #1042#1099#1073#1086#1088' '#1079#1072#1076#1072#1095#1080
    ItemIndex = 0
    Items.Strings = (
      #1052#1072#1082#1089#1080#1084#1072#1083#1100#1085#1086#1077' '#1082#1086#1083'-'#1074#1086' '#1088#1077#1076#1082#1080#1093
      #1044#1086#1083#1103' '#1088#1077#1076#1082#1080#1093' '#1084#1077#1085#1100#1096#1077' '#1079#1072#1076#1072#1085#1085#1086#1075#1086)
    TabOrder = 0
  end
  object UniquePartEdit: TLabeledEdit
    Left = 464
    Top = 64
    Width = 121
    Height = 31
    EditLabel.Width = 111
    EditLabel.Height = 23
    EditLabel.Caption = #1044#1086#1083#1103' '#1088#1077#1076#1082#1080#1093
    TabOrder = 1
  end
  object OutputSG: TStringGrid
    Left = 24
    Top = 160
    Width = 450
    Height = 233
    Anchors = [akLeft, akTop, akBottom]
    ColCount = 3
    DefaultColWidth = 148
    FixedCols = 0
    TabOrder = 2
  end
  object OKbtn: TButton
    Left = 576
    Top = 344
    Width = 113
    Height = 49
    Caption = 'OK'
    TabOrder = 3
    OnClick = OKbtnClick
  end
end
