//---------------------------------------------------------------------------

#ifndef MainWindowH
#define MainWindowH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.Menus.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TMainMenu *MainMenu1;
	TMenuItem *File1;
	TMenuItem *Quit1;
	TMenuItem *Work1;
	TMenuItem *Control1;
	TMenuItem *ile1;
	TMenuItem *Cascade1;
	TMenuItem *CloseCurrent1;
	TMenuItem *CloseAll1;
	TMenuItem *Help1;
	TMenuItem *About1;
	TMenuItem *Dialog1;
	TMenuItem *Proc1;
	void __fastcall Quit1Click(TObject *Sender);
	void __fastcall About1Click(TObject *Sender);
	void __fastcall Dialog1Click(TObject *Sender);
	void __fastcall Proc1Click(TObject *Sender);
	void __fastcall ile1Click(TObject *Sender);
	void __fastcall Cascade1Click(TObject *Sender);
	void __fastcall CloseCurrent1Click(TObject *Sender);
	void __fastcall CloseAll1Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
