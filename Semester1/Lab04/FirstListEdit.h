//---------------------------------------------------------------------------

#ifndef FirstListEditH
#define FirstListEditH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TFormListInput : public TForm
{
__published:	// IDE-managed Components
	TLabeledEdit *SpeciesEdit;
	TLabeledEdit *UniqueSpeciesEdit;
	TButton *InputBtn;
	TLabeledEdit *ZooEdit;
	void __fastcall FormClose(TObject *Sender, TCloseAction &Action);
	void __fastcall InputBtnClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TFormListInput(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TFormListInput *FormListInput;
//---------------------------------------------------------------------------
#endif
