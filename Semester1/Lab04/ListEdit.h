//---------------------------------------------------------------------------

#ifndef ListEditH
#define ListEditH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.ButtonGroup.hpp>
#include <Vcl.ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TFormListEdit : public TForm
{
__published:	// IDE-managed Components
	TButton *NextBtn;
	TButton *PrevBtn;
	TLabeledEdit *ZooEdit;
	TLabeledEdit *SpeciesEdit;
	TLabeledEdit *UniqueSpeciesEdit;
	TButton *DeleteBtn;
	TButton *ChangeBtn;
	void __fastcall FormClose(TObject *Sender, TCloseAction &Action);
	void __fastcall NextBtnClick(TObject *Sender);
	void __fastcall PrevBtnClick(TObject *Sender);
	void __fastcall DeleteBtnClick(TObject *Sender);
	void __fastcall ChangeBtnClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TFormListEdit(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TFormListEdit *FormListEdit;
//---------------------------------------------------------------------------
#endif
