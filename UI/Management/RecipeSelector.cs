using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006F8 RID: 1784
	public class RecipeSelector : ClipboardScreen
	{
		// Token: 0x06009FA7 RID: 40871 RVA: 0x00288960 File Offset: 0x00286B60
		// Note: this type is marked as 'beforefieldinit'.
		static RecipeSelector()
		{
			Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RecipeSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr);
			RecipeSelector.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "OptionContainer");
			RecipeSelector.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "TitleLabel");
			RecipeSelector.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "OptionPrefab");
			RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "EmptyOptionSprite");
			RecipeSelector.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "lerpRoutine");
			RecipeSelector.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "options");
			RecipeSelector.NativeFieldInfoPtr_selectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "selectedOption");
			RecipeSelector.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "optionButtons");
			RecipeSelector.NativeFieldInfoPtr_optionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "optionCallback");
			RecipeSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682990);
			RecipeSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682991);
			RecipeSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682992);
			RecipeSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682993);
			RecipeSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682994);
			RecipeSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682995);
			RecipeSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682996);
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x00288AD0 File Offset: 0x00286CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283337, RefRangeEnd = 283338, XrefRangeStart = 283311, XrefRangeEnd = 283337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string selectionTitle, List<StationRecipe> _options, StationRecipe _selectedOption = null, Il2CppSystem.Action<StationRecipe> _optionCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_options);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedOption);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_optionCallback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x00288B4C File Offset: 0x00286D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283338, XrefRangeEnd = 283358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x00288B88 File Offset: 0x00286D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283358, XrefRangeEnd = 283370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FAB RID: 40875 RVA: 0x00288BC4 File Offset: 0x00286DC4
		[CallerCount(0)]
		public unsafe void ButtonClicked(StationRecipe option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FAC RID: 40876 RVA: 0x00288C08 File Offset: 0x00286E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283435, RefRangeEnd = 283436, XrefRangeStart = 283370, XrefRangeEnd = 283435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOptions(List<StationRecipe> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x00288C4C File Offset: 0x00286E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283436, XrefRangeEnd = 283448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FAE RID: 40878 RVA: 0x00288C80 File Offset: 0x00286E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283448, XrefRangeEnd = 283463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecipeSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FAF RID: 40879 RVA: 0x0004E127 File Offset: 0x0004C327
		public RecipeSelector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x06009FB0 RID: 40880 RVA: 0x00288CBC File Offset: 0x00286EBC
		// (set) Token: 0x06009FB1 RID: 40881 RVA: 0x0004E130 File Offset: 0x0004C330
		public unsafe RectTransform OptionContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x06009FB2 RID: 40882 RVA: 0x00288CEC File Offset: 0x00286EEC
		// (set) Token: 0x06009FB3 RID: 40883 RVA: 0x0004E14F File Offset: 0x0004C34F
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_TitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x06009FB4 RID: 40884 RVA: 0x00288D1C File Offset: 0x00286F1C
		// (set) Token: 0x06009FB5 RID: 40885 RVA: 0x0004E16E File Offset: 0x0004C36E
		public unsafe GameObject OptionPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x06009FB6 RID: 40886 RVA: 0x00288D4C File Offset: 0x00286F4C
		// (set) Token: 0x06009FB7 RID: 40887 RVA: 0x0004E18D File Offset: 0x0004C38D
		public unsafe Sprite EmptyOptionSprite
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x06009FB8 RID: 40888 RVA: 0x00288D7C File Offset: 0x00286F7C
		// (set) Token: 0x06009FB9 RID: 40889 RVA: 0x0004E1AC File Offset: 0x0004C3AC
		public new unsafe Coroutine lerpRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_lerpRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x06009FBA RID: 40890 RVA: 0x00288DAC File Offset: 0x00286FAC
		// (set) Token: 0x06009FBB RID: 40891 RVA: 0x0004E1CB File Offset: 0x0004C3CB
		public unsafe List<StationRecipe> options
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_options);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x06009FBC RID: 40892 RVA: 0x00288DDC File Offset: 0x00286FDC
		// (set) Token: 0x06009FBD RID: 40893 RVA: 0x0004E1EA File Offset: 0x0004C3EA
		public unsafe StationRecipe selectedOption
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_selectedOption);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_selectedOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x06009FBE RID: 40894 RVA: 0x00288E0C File Offset: 0x0028700C
		// (set) Token: 0x06009FBF RID: 40895 RVA: 0x0004E209 File Offset: 0x0004C409
		public unsafe List<RectTransform> optionButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x06009FC0 RID: 40896 RVA: 0x00288E3C File Offset: 0x0028703C
		// (set) Token: 0x06009FC1 RID: 40897 RVA: 0x0004E228 File Offset: 0x0004C428
		public unsafe Il2CppSystem.Action<StationRecipe> optionCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B3F RID: 27455
		private static readonly System.IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006B40 RID: 27456
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006B41 RID: 27457
		private static readonly System.IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04006B42 RID: 27458
		private static readonly System.IntPtr NativeFieldInfoPtr_EmptyOptionSprite;

		// Token: 0x04006B43 RID: 27459
		private static readonly System.IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04006B44 RID: 27460
		private static readonly System.IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04006B45 RID: 27461
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedOption;

		// Token: 0x04006B46 RID: 27462
		private static readonly System.IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006B47 RID: 27463
		private static readonly System.IntPtr NativeFieldInfoPtr_optionCallback;

		// Token: 0x04006B48 RID: 27464
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0;

		// Token: 0x04006B49 RID: 27465
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04006B4A RID: 27466
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04006B4B RID: 27467
		private static readonly System.IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0;

		// Token: 0x04006B4C RID: 27468
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0;

		// Token: 0x04006B4D RID: 27469
		private static readonly System.IntPtr NativeMethodInfoPtr_DeleteOptions_Private_Void_0;

		// Token: 0x04006B4E RID: 27470
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE7 RID: 3047
		[ObfuscatedName("ScheduleOne.UI.Management.RecipeSelector+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E165 RID: 57701 RVA: 0x00357318 File Offset: 0x00355518
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr);
				RecipeSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, "<>9");
				RecipeSelector.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, "<>9__13_0");
				RecipeSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, 100682998);
				RecipeSelector.__c.NativeMethodInfoPtr__CreateOptions_b__13_0_Internal_Int32_StationRecipe_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, 100682999);
			}

			// Token: 0x0600E166 RID: 57702 RVA: 0x00357394 File Offset: 0x00355594
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E167 RID: 57703 RVA: 0x003573D0 File Offset: 0x003555D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283308, XrefRangeEnd = 283310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CreateOptions_b__13_0(StationRecipe a, StationRecipe b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c.NativeMethodInfoPtr__CreateOptions_b__13_0_Internal_Int32_StationRecipe_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E168 RID: 57704 RVA: 0x0006D785 File Offset: 0x0006B985
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458C RID: 17804
			// (get) Token: 0x0600E169 RID: 57705 RVA: 0x00357430 File Offset: 0x00355630
			// (set) Token: 0x0600E16A RID: 57706 RVA: 0x0006D78E File Offset: 0x0006B98E
			public unsafe static RecipeSelector.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RecipeSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RecipeSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458D RID: 17805
			// (get) Token: 0x0600E16B RID: 57707 RVA: 0x00357458 File Offset: 0x00355658
			// (set) Token: 0x0600E16C RID: 57708 RVA: 0x0006D7A0 File Offset: 0x0006B9A0
			public unsafe static Il2CppSystem.Comparison<StationRecipe> __9__13_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RecipeSelector.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<StationRecipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RecipeSelector.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009727 RID: 38695
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009728 RID: 38696
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04009729 RID: 38697
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400972A RID: 38698
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateOptions_b__13_0_Internal_Int32_StationRecipe_StationRecipe_0;
		}

		// Token: 0x02000BE8 RID: 3048
		[ObfuscatedName("ScheduleOne.UI.Management.RecipeSelector+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E16D RID: 57709 RVA: 0x00357480 File Offset: 0x00355680
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr);
				RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr_opt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, "opt");
				RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, 100683000);
				RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, 100683001);
			}

			// Token: 0x0600E16E RID: 57710 RVA: 0x003574FC File Offset: 0x003556FC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E16F RID: 57711 RVA: 0x00357538 File Offset: 0x00355738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283310, XrefRangeEnd = 283311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E170 RID: 57712 RVA: 0x0006D7B2 File Offset: 0x0006B9B2
			public __c__DisplayClass13_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458E RID: 17806
			// (get) Token: 0x0600E171 RID: 57713 RVA: 0x0035756C File Offset: 0x0035576C
			// (set) Token: 0x0600E172 RID: 57714 RVA: 0x0006D7BB File Offset: 0x0006B9BB
			public unsafe StationRecipe opt
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr_opt);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr_opt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458F RID: 17807
			// (get) Token: 0x0600E173 RID: 57715 RVA: 0x0035759C File Offset: 0x0035579C
			// (set) Token: 0x0600E174 RID: 57716 RVA: 0x0006D7DA File Offset: 0x0006B9DA
			public unsafe RecipeSelector __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400972B RID: 38699
			private static readonly System.IntPtr NativeFieldInfoPtr_opt;

			// Token: 0x0400972C RID: 38700
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400972D RID: 38701
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400972E RID: 38702
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0;
		}
	}
}
