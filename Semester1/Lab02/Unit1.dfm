object Form1: TForm1
  Left = 0
  Top = 0
  Align = alTop
  Caption = 'Form1'
  ClientHeight = 377
  ClientWidth = 680
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object MainMenu1: TMainMenu
    Left = 616
    Top = 304
    object File1: TMenuItem
      Caption = 'File'
      object Exit1: TMenuItem
        Caption = 'Exit'
        OnClick = Exit1Click
      end
    end
    object Work1: TMenuItem
      Caption = 'Work'
      object Dialog1: TMenuItem
        Caption = 'Dialog'
        OnClick = Dialog1Click
      end
      object Proc1: TMenuItem
        Caption = 'Proc'
        OnClick = Proc1Click
      end
    end
    object Help1: TMenuItem
      Caption = 'Help'
      object About1: TMenuItem
        Caption = 'About'
        OnClick = About1Click
      end
    end
  end
end
