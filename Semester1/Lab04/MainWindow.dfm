object FormMain: TFormMain
  Left = 0
  Top = 0
  Caption = #1051#1072#1073#1086#1088#1072#1090#1086#1088#1085#1072#1103' '#1088#1072#1073#1086#1090#1072' 4'
  ClientHeight = 359
  ClientWidth = 665
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -19
  Font.Name = 'Tahoma'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 23
  object MainMenu1: TMainMenu
    Left = 544
    Top = 264
    object File1: TMenuItem
      Caption = 'File'
      object Exit1: TMenuItem
        Caption = 'Exit'
        OnClick = Exit1Click
      end
    end
    object Work1: TMenuItem
      Caption = 'Work'
      object Input1: TMenuItem
        Caption = 'Input'
        OnClick = Input1Click
      end
      object Edit1: TMenuItem
        Caption = 'Edit'
        OnClick = Edit1Click
      end
      object ask1: TMenuItem
        Caption = 'Task'
        OnClick = ask1Click
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
