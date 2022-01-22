//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <FMX.Controls.hpp>
#include <FMX.Forms.hpp>
#include <FMX.Types.hpp>
#include <FMX.Ani.hpp>
#include <FMX.Gestures.hpp>
#include <FMX.Layouts.hpp>
#include <FMX.Colors.hpp>
#include <FMX.Controls.Presentation.hpp>
#include <FMX.StdCtrls.hpp>
#include <FMX.Objects.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TStyleBook *StyleBook1;
	TLayout *ToolbarHolder;
	TPopup *ToolbarPopup;
	TFloatAnimation *ToolbarPopupAnimation;
	TToolBar *ToolBar1;
	TButton *ToolbarApplyButton;
	TButton *ToolbarCloseButton;
	TButton *ToolbarAddButton;
	TCircle *Circle1;
	TColorAnimation *ColorAnimation1;
	TText *Text1;
	void __fastcall FormKeyDown(TObject *Sender, WORD &Key, System::WideChar &KeyChar,
		  TShiftState Shift);
	void __fastcall ToolbarCloseButtonClick(TObject *Sender);
	void __fastcall FormGesture(TObject *Sender, const TGestureEventInfo &EventInfo,
          bool &Handled);
private:	// User declarations
	TPointF FGestureOrigin;
	bool FGestureInProgress;
	void ShowToolbar(bool AShow);
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
