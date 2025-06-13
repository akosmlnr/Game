using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000662 RID: 1634
	public class GenericSelectionModule : Singleton<GenericSelectionModule>
	{
		// Token: 0x06008F73 RID: 36723 RVA: 0x002588C8 File Offset: 0x00256AC8
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSelectionModule()
		{
			Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GenericSelectionModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr);
			GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<isOpen>k__BackingField");
			GenericSelectionModule.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "canvas");
			GenericSelectionModule.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "TitleText");
			GenericSelectionModule.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "OptionContainer");
			GenericSelectionModule.NativeFieldInfoPtr_CloseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "CloseButton");
			GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "ListOptionPrefab");
			GenericSelectionModule.NativeFieldInfoPtr_OptionChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "OptionChosen");
			GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<ChosenOptionIndex>k__BackingField");
			GenericSelectionModule.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681224);
			GenericSelectionModule.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681225);
			GenericSelectionModule.NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681226);
			GenericSelectionModule.NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681227);
			GenericSelectionModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681228);
			GenericSelectionModule.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681229);
			GenericSelectionModule.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681230);
			GenericSelectionModule.NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681231);
			GenericSelectionModule.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681232);
			GenericSelectionModule.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681233);
			GenericSelectionModule.NativeMethodInfoPtr_ClearOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681234);
			GenericSelectionModule.NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681235);
			GenericSelectionModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100681236);
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x06008F74 RID: 36724 RVA: 0x00258A9C File Offset: 0x00256C9C
		// (set) Token: 0x06008F75 RID: 36725 RVA: 0x00258AD8 File Offset: 0x00256CD8
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x06008F76 RID: 36726 RVA: 0x00258B18 File Offset: 0x00256D18
		// (set) Token: 0x06008F77 RID: 36727 RVA: 0x00258B54 File Offset: 0x00256D54
		public unsafe int ChosenOptionIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 71932, RefRangeEnd = 71938, XrefRangeStart = 71932, XrefRangeEnd = 71938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 261677, RefRangeEnd = 261687, XrefRangeStart = 261677, XrefRangeEnd = 261677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008F78 RID: 36728 RVA: 0x00258B94 File Offset: 0x00256D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261687, XrefRangeEnd = 261693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSelectionModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F79 RID: 36729 RVA: 0x00258BD0 File Offset: 0x00256DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261693, XrefRangeEnd = 261706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSelectionModule.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F7A RID: 36730 RVA: 0x00258C0C File Offset: 0x00256E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261706, XrefRangeEnd = 261709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F7B RID: 36731 RVA: 0x00258C50 File Offset: 0x00256E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261709, XrefRangeEnd = 261749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F7C RID: 36732 RVA: 0x00258CA4 File Offset: 0x00256EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261749, XrefRangeEnd = 261752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F7D RID: 36733 RVA: 0x00258CD8 File Offset: 0x00256ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261752, XrefRangeEnd = 261755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F7E RID: 36734 RVA: 0x00258D0C File Offset: 0x00256F0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 261762, RefRangeEnd = 261769, XrefRangeStart = 261755, XrefRangeEnd = 261762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_ClearOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F7F RID: 36735 RVA: 0x00258D40 File Offset: 0x00256F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261769, XrefRangeEnd = 261772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListOptionClicked(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F80 RID: 36736 RVA: 0x00258D80 File Offset: 0x00256F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261772, XrefRangeEnd = 261775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSelectionModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F81 RID: 36737 RVA: 0x000448D2 File Offset: 0x00042AD2
		public GenericSelectionModule(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x06008F82 RID: 36738 RVA: 0x00258DBC File Offset: 0x00256FBC
		// (set) Token: 0x06008F83 RID: 36739 RVA: 0x000448DB File Offset: 0x00042ADB
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x06008F84 RID: 36740 RVA: 0x00258DE4 File Offset: 0x00256FE4
		// (set) Token: 0x06008F85 RID: 36741 RVA: 0x000448F6 File Offset: 0x00042AF6
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x06008F86 RID: 36742 RVA: 0x00258E14 File Offset: 0x00257014
		// (set) Token: 0x06008F87 RID: 36743 RVA: 0x00044915 File Offset: 0x00042B15
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_TitleText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x06008F88 RID: 36744 RVA: 0x00258E44 File Offset: 0x00257044
		// (set) Token: 0x06008F89 RID: 36745 RVA: 0x00044934 File Offset: 0x00042B34
		public unsafe RectTransform OptionContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x06008F8A RID: 36746 RVA: 0x00258E74 File Offset: 0x00257074
		// (set) Token: 0x06008F8B RID: 36747 RVA: 0x00044953 File Offset: 0x00042B53
		public unsafe Button CloseButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_CloseButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_CloseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x06008F8C RID: 36748 RVA: 0x00258EA4 File Offset: 0x002570A4
		// (set) Token: 0x06008F8D RID: 36749 RVA: 0x00044972 File Offset: 0x00042B72
		public unsafe GameObject ListOptionPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x06008F8E RID: 36750 RVA: 0x00258ED4 File Offset: 0x002570D4
		// (set) Token: 0x06008F8F RID: 36751 RVA: 0x00044991 File Offset: 0x00042B91
		public unsafe bool OptionChosen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionChosen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionChosen)) = value;
			}
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x06008F90 RID: 36752 RVA: 0x00258EFC File Offset: 0x002570FC
		// (set) Token: 0x06008F91 RID: 36753 RVA: 0x000449AC File Offset: 0x00042BAC
		public unsafe int _ChosenOptionIndex_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x04006139 RID: 24889
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x0400613A RID: 24890
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x0400613B RID: 24891
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x0400613C RID: 24892
		private static readonly System.IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x0400613D RID: 24893
		private static readonly System.IntPtr NativeFieldInfoPtr_CloseButton;

		// Token: 0x0400613E RID: 24894
		private static readonly System.IntPtr NativeFieldInfoPtr_ListOptionPrefab;

		// Token: 0x0400613F RID: 24895
		private static readonly System.IntPtr NativeFieldInfoPtr_OptionChosen;

		// Token: 0x04006140 RID: 24896
		private static readonly System.IntPtr NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField;

		// Token: 0x04006141 RID: 24897
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006142 RID: 24898
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006143 RID: 24899
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0;

		// Token: 0x04006144 RID: 24900
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0;

		// Token: 0x04006145 RID: 24901
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006146 RID: 24902
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006147 RID: 24903
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006148 RID: 24904
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0;

		// Token: 0x04006149 RID: 24905
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400614A RID: 24906
		private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x0400614B RID: 24907
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearOptions_Private_Void_0;

		// Token: 0x0400614C RID: 24908
		private static readonly System.IntPtr NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0;

		// Token: 0x0400614D RID: 24909
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B72 RID: 2930
		[ObfuscatedName("ScheduleOne.UI.GenericSelectionModule+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCAB RID: 56491 RVA: 0x00349A5C File Offset: 0x00347C5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr);
				GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, "index");
				GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, 100681237);
				GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, 100681238);
			}

			// Token: 0x0600DCAC RID: 56492 RVA: 0x00349AD8 File Offset: 0x00347CD8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCAD RID: 56493 RVA: 0x00349B14 File Offset: 0x00347D14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261674, XrefRangeEnd = 261677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCAE RID: 56494 RVA: 0x0006B1D4 File Offset: 0x000693D4
			public __c__DisplayClass17_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004416 RID: 17430
			// (get) Token: 0x0600DCAF RID: 56495 RVA: 0x00349B48 File Offset: 0x00347D48
			// (set) Token: 0x0600DCB0 RID: 56496 RVA: 0x0006B1DD File Offset: 0x000693DD
			public unsafe int index
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004417 RID: 17431
			// (get) Token: 0x0600DCB1 RID: 56497 RVA: 0x00349B70 File Offset: 0x00347D70
			// (set) Token: 0x0600DCB2 RID: 56498 RVA: 0x0006B1F8 File Offset: 0x000693F8
			public unsafe GenericSelectionModule __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericSelectionModule>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400946B RID: 37995
			private static readonly System.IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400946C RID: 37996
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400946D RID: 37997
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400946E RID: 37998
			private static readonly System.IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Void_0;
		}
	}
}
