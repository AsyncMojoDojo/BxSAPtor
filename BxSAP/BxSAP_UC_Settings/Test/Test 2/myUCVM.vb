﻿Imports BxSAP_UC_Settings.Helpers
'••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
Namespace myUC

	Public Class myUCVM
								Inherits ViewModelBase

		'Private co_SaveCmd	As RelayCommand
		Private cb_auto	As Boolean

		Public ReadOnly Property SaveCommand()	As RelayCommand
			Get
				Return	New RelayCommand(AddressOf Save)
			End Get
		End Property


		Public Property Autosave()	As Boolean
			Get
				Return	Me.cb_auto
			End Get
		    Set(value As Boolean)
					Me.SetProperty(Me.cb_auto,value)
		    End Set
		End Property




		Public Sub New()
		End Sub



		Private Sub Save()
			Me.Autosave	= Not Me.Autosave
		End Sub


	End Class

End Namespace
