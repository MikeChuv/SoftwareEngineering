object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 485
  ClientWidth = 849
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -19
  Font.Name = 'Tahoma'
  Font.Style = []
  FormStyle = fsMDIForm
  Menu = MainMenu1
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 23
  object MainMenu1: TMainMenu
    Left = 664
    Top = 416
    object File1: TMenuItem
      Caption = 'File'
      object Quit1: TMenuItem
        Caption = 'Exit'
        OnClick = Quit1Click
      end
    end
    object Work1: TMenuItem
      Caption = 'Work'
      GroupIndex = 10
      object Dialog1: TMenuItem
        Caption = 'Dialog'
        OnClick = Dialog1Click
      end
      object Proc1: TMenuItem
        Caption = 'Proc'
        OnClick = Proc1Click
      end
    end
    object Control1: TMenuItem
      Caption = 'Control'
      GroupIndex = 20
      object ile1: TMenuItem
        Caption = 'Tile'
        OnClick = ile1Click
      end
      object Cascade1: TMenuItem
        Caption = 'Cascade'
        OnClick = Cascade1Click
      end
      object CloseCurrent1: TMenuItem
        Caption = 'Close Current'
        OnClick = CloseCurrent1Click
      end
      object CloseAll1: TMenuItem
        Caption = 'Close All'
        OnClick = CloseAll1Click
      end
    end
    object Help1: TMenuItem
      Caption = 'Help'
      GroupIndex = 30
      object About1: TMenuItem
        Caption = 'About'
        OnClick = About1Click
      end
    end
  end
end
