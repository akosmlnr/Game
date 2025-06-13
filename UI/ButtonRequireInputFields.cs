using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200068E RID: 1678
	public class ButtonRequireInputFields : MonoBehaviour
	{
		// Token: 0x060094F1 RID: 38129 RVA: 0x00268B80 File Offset: 0x00266D80
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonRequireInputFields()
		{
			Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ButtonRequireInputFields");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr);
			ButtonRequireInputFields.NativeFieldInfoPtr_Inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Inputs");
			ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Dropdown");
			ButtonRequireInputFields.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Button");
			ButtonRequireInputFields.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, 100681882);
			ButtonRequireInputFields.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, 100681883);
		}

		// Token: 0x060094F2 RID: 38130 RVA: 0x00268C14 File Offset: 0x00266E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268772, XrefRangeEnd = 268799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x00268C48 File Offset: 0x00266E48
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonRequireInputFields() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x00047D02 File Offset: 0x00045F02
		public ButtonRequireInputFields(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x060094F5 RID: 38133 RVA: 0x00268C84 File Offset: 0x00266E84
		// (set) Token: 0x060094F6 RID: 38134 RVA: 0x00047D0B File Offset: 0x00045F0B
		public unsafe List<ButtonRequireInputFields.Input> Inputs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Inputs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ButtonRequireInputFields.Input>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Inputs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x060094F7 RID: 38135 RVA: 0x00268CB4 File Offset: 0x00266EB4
		// (set) Token: 0x060094F8 RID: 38136 RVA: 0x00047D2A File Offset: 0x00045F2A
		public unsafe TMP_Dropdown Dropdown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x060094F9 RID: 38137 RVA: 0x00268CE4 File Offset: 0x00266EE4
		// (set) Token: 0x060094FA RID: 38138 RVA: 0x00047D49 File Offset: 0x00045F49
		public unsafe Button Button
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Button);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064A6 RID: 25766
		private static readonly System.IntPtr NativeFieldInfoPtr_Inputs;

		// Token: 0x040064A7 RID: 25767
		private static readonly System.IntPtr NativeFieldInfoPtr_Dropdown;

		// Token: 0x040064A8 RID: 25768
		private static readonly System.IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040064A9 RID: 25769
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040064AA RID: 25770
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B9F RID: 2975
		[System.Serializable]
		public class Input : Il2CppSystem.Object
		{
			// Token: 0x0600DED3 RID: 57043 RVA: 0x0034FEA0 File Offset: 0x0034E0A0
			// Note: this type is marked as 'beforefieldinit'.
			static Input()
			{
				Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Input");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr);
				ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, "InputField");
				ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, "ErrorMessage");
				ButtonRequireInputFields.Input.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, 100681884);
			}

			// Token: 0x0600DED4 RID: 57044 RVA: 0x0034FF08 File Offset: 0x0034E108
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Input() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.Input.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DED5 RID: 57045 RVA: 0x0006C339 File Offset: 0x0006A539
			public Input(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044D4 RID: 17620
			// (get) Token: 0x0600DED6 RID: 57046 RVA: 0x0034FF44 File Offset: 0x0034E144
			// (set) Token: 0x0600DED7 RID: 57047 RVA: 0x0006C342 File Offset: 0x0006A542
			public unsafe TMP_InputField InputField
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D5 RID: 17621
			// (get) Token: 0x0600DED8 RID: 57048 RVA: 0x0034FF74 File Offset: 0x0034E174
			// (set) Token: 0x0600DED9 RID: 57049 RVA: 0x0006C361 File Offset: 0x0006A561
			public unsafe RectTransform ErrorMessage
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095BD RID: 38333
			private static readonly System.IntPtr NativeFieldInfoPtr_InputField;

			// Token: 0x040095BE RID: 38334
			private static readonly System.IntPtr NativeFieldInfoPtr_ErrorMessage;

			// Token: 0x040095BF RID: 38335
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
