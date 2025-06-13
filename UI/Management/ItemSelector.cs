using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006F4 RID: 1780
	public class ItemSelector : ClipboardScreen
	{
		// Token: 0x06009F05 RID: 40709 RVA: 0x0028695C File Offset: 0x00284B5C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelector()
		{
			Il2CppClassPointerStore<ItemSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ItemSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr);
			ItemSelector.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "OptionContainer");
			ItemSelector.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "TitleLabel");
			ItemSelector.NativeFieldInfoPtr_HoveredItemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "HoveredItemLabel");
			ItemSelector.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "OptionPrefab");
			ItemSelector.NativeFieldInfoPtr_EmptyOptionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "EmptyOptionSprite");
			ItemSelector.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "lerpRoutine");
			ItemSelector.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "options");
			ItemSelector.NativeFieldInfoPtr_selectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "selectedOption");
			ItemSelector.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "optionButtons");
			ItemSelector.NativeFieldInfoPtr_optionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "optionCallback");
			ItemSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_Option_Option_Action_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682920);
			ItemSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682921);
			ItemSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682922);
			ItemSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682923);
			ItemSelector.NativeMethodInfoPtr_ButtonHovered_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682924);
			ItemSelector.NativeMethodInfoPtr_ButtonHoverEnd_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682925);
			ItemSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682926);
			ItemSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682927);
			ItemSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682928);
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x00286B08 File Offset: 0x00284D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282165, RefRangeEnd = 282166, XrefRangeStart = 282138, XrefRangeEnd = 282165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string selectionTitle, List<ItemSelector.Option> _options, ItemSelector.Option _selectedOption = null, Il2CppSystem.Action<ItemSelector.Option> _optionCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_options);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedOption);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_optionCallback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_Option_Option_Action_1_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F07 RID: 40711 RVA: 0x00286B84 File Offset: 0x00284D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282166, XrefRangeEnd = 282172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F08 RID: 40712 RVA: 0x00286BC0 File Offset: 0x00284DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282172, XrefRangeEnd = 282179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F09 RID: 40713 RVA: 0x00286BFC File Offset: 0x00284DFC
		[CallerCount(0)]
		public unsafe void ButtonClicked(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F0A RID: 40714 RVA: 0x00286C40 File Offset: 0x00284E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282179, XrefRangeEnd = 282191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonHovered(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_ButtonHovered_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F0B RID: 40715 RVA: 0x00286C84 File Offset: 0x00284E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282191, XrefRangeEnd = 282193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonHoverEnd(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_ButtonHoverEnd_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F0C RID: 40716 RVA: 0x00286CC8 File Offset: 0x00284EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282305, RefRangeEnd = 282306, XrefRangeStart = 282193, XrefRangeEnd = 282305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOptions(List<ItemSelector.Option> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F0D RID: 40717 RVA: 0x00286D0C File Offset: 0x00284F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282306, XrefRangeEnd = 282318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F0E RID: 40718 RVA: 0x00286D40 File Offset: 0x00284F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282318, XrefRangeEnd = 282333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F0F RID: 40719 RVA: 0x0004DB8C File Offset: 0x0004BD8C
		public ItemSelector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x06009F10 RID: 40720 RVA: 0x00286D7C File Offset: 0x00284F7C
		// (set) Token: 0x06009F11 RID: 40721 RVA: 0x0004DB95 File Offset: 0x0004BD95
		public unsafe RectTransform OptionContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x06009F12 RID: 40722 RVA: 0x00286DAC File Offset: 0x00284FAC
		// (set) Token: 0x06009F13 RID: 40723 RVA: 0x0004DBB4 File Offset: 0x0004BDB4
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_TitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x06009F14 RID: 40724 RVA: 0x00286DDC File Offset: 0x00284FDC
		// (set) Token: 0x06009F15 RID: 40725 RVA: 0x0004DBD3 File Offset: 0x0004BDD3
		public unsafe TextMeshProUGUI HoveredItemLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_HoveredItemLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_HoveredItemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x06009F16 RID: 40726 RVA: 0x00286E0C File Offset: 0x0028500C
		// (set) Token: 0x06009F17 RID: 40727 RVA: 0x0004DBF2 File Offset: 0x0004BDF2
		public unsafe GameObject OptionPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x06009F18 RID: 40728 RVA: 0x00286E3C File Offset: 0x0028503C
		// (set) Token: 0x06009F19 RID: 40729 RVA: 0x0004DC11 File Offset: 0x0004BE11
		public unsafe Sprite EmptyOptionSprite
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_EmptyOptionSprite);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_EmptyOptionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x06009F1A RID: 40730 RVA: 0x00286E6C File Offset: 0x0028506C
		// (set) Token: 0x06009F1B RID: 40731 RVA: 0x0004DC30 File Offset: 0x0004BE30
		public new unsafe Coroutine lerpRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_lerpRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x06009F1C RID: 40732 RVA: 0x00286E9C File Offset: 0x0028509C
		// (set) Token: 0x06009F1D RID: 40733 RVA: 0x0004DC4F File Offset: 0x0004BE4F
		public unsafe List<ItemSelector.Option> options
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_options);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSelector.Option>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x06009F1E RID: 40734 RVA: 0x00286ECC File Offset: 0x002850CC
		// (set) Token: 0x06009F1F RID: 40735 RVA: 0x0004DC6E File Offset: 0x0004BE6E
		public unsafe ItemSelector.Option selectedOption
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_selectedOption);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector.Option>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_selectedOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x06009F20 RID: 40736 RVA: 0x00286EFC File Offset: 0x002850FC
		// (set) Token: 0x06009F21 RID: 40737 RVA: 0x0004DC8D File Offset: 0x0004BE8D
		public unsafe List<RectTransform> optionButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x06009F22 RID: 40738 RVA: 0x00286F2C File Offset: 0x0028512C
		// (set) Token: 0x06009F23 RID: 40739 RVA: 0x0004DCAC File Offset: 0x0004BEAC
		public unsafe Il2CppSystem.Action<ItemSelector.Option> optionCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ItemSelector.Option>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AD6 RID: 27350
		private static readonly System.IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006AD7 RID: 27351
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006AD8 RID: 27352
		private static readonly System.IntPtr NativeFieldInfoPtr_HoveredItemLabel;

		// Token: 0x04006AD9 RID: 27353
		private static readonly System.IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04006ADA RID: 27354
		private static readonly System.IntPtr NativeFieldInfoPtr_EmptyOptionSprite;

		// Token: 0x04006ADB RID: 27355
		private static readonly System.IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04006ADC RID: 27356
		private static readonly System.IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04006ADD RID: 27357
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedOption;

		// Token: 0x04006ADE RID: 27358
		private static readonly System.IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006ADF RID: 27359
		private static readonly System.IntPtr NativeFieldInfoPtr_optionCallback;

		// Token: 0x04006AE0 RID: 27360
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_Option_Option_Action_1_Option_0;

		// Token: 0x04006AE1 RID: 27361
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04006AE2 RID: 27362
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04006AE3 RID: 27363
		private static readonly System.IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_Option_0;

		// Token: 0x04006AE4 RID: 27364
		private static readonly System.IntPtr NativeMethodInfoPtr_ButtonHovered_Private_Void_Option_0;

		// Token: 0x04006AE5 RID: 27365
		private static readonly System.IntPtr NativeMethodInfoPtr_ButtonHoverEnd_Private_Void_Option_0;

		// Token: 0x04006AE6 RID: 27366
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_Option_0;

		// Token: 0x04006AE7 RID: 27367
		private static readonly System.IntPtr NativeMethodInfoPtr_DeleteOptions_Private_Void_0;

		// Token: 0x04006AE8 RID: 27368
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE2 RID: 3042
		[System.Serializable]
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600E13E RID: 57662 RVA: 0x00356B18 File Offset: 0x00354D18
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr);
				ItemSelector.Option.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr, "Title");
				ItemSelector.Option.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr, "Item");
				ItemSelector.Option.NativeMethodInfoPtr__ctor_Public_Void_String_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr, 100682929);
			}

			// Token: 0x0600E13F RID: 57663 RVA: 0x00356B80 File Offset: 0x00354D80
			[CallerCount(51)]
			[CachedScanResults(RefRangeStart = 114146, RefRangeEnd = 114197, XrefRangeStart = 114146, XrefRangeEnd = 114197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option(string title, ItemDefinition item) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.Option.NativeMethodInfoPtr__ctor_Public_Void_String_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E140 RID: 57664 RVA: 0x0006D67A File Offset: 0x0006B87A
			public Option(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004584 RID: 17796
			// (get) Token: 0x0600E141 RID: 57665 RVA: 0x00356BE0 File Offset: 0x00354DE0
			// (set) Token: 0x0600E142 RID: 57666 RVA: 0x0006D683 File Offset: 0x0006B883
			public unsafe string Title
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004585 RID: 17797
			// (get) Token: 0x0600E143 RID: 57667 RVA: 0x00356C08 File Offset: 0x00354E08
			// (set) Token: 0x0600E144 RID: 57668 RVA: 0x0006D6A2 File Offset: 0x0006B8A2
			public unsafe ItemDefinition Item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009712 RID: 38674
			private static readonly System.IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x04009713 RID: 38675
			private static readonly System.IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04009714 RID: 38676
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ItemDefinition_0;
		}

		// Token: 0x02000BE3 RID: 3043
		[ObfuscatedName("ScheduleOne.UI.Management.ItemSelector+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E145 RID: 57669 RVA: 0x00356C38 File Offset: 0x00354E38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr);
				ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_opt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, "opt");
				ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682930);
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682931);
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682932);
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682933);
			}

			// Token: 0x0600E146 RID: 57670 RVA: 0x00356CDC File Offset: 0x00354EDC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E147 RID: 57671 RVA: 0x00356D18 File Offset: 0x00354F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282123, XrefRangeEnd = 282124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E148 RID: 57672 RVA: 0x00356D4C File Offset: 0x00354F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282124, XrefRangeEnd = 282136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E149 RID: 57673 RVA: 0x00356D90 File Offset: 0x00354F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282136, XrefRangeEnd = 282138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__2(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E14A RID: 57674 RVA: 0x0006D6C1 File Offset: 0x0006B8C1
			public __c__DisplayClass17_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004586 RID: 17798
			// (get) Token: 0x0600E14B RID: 57675 RVA: 0x00356DD4 File Offset: 0x00354FD4
			// (set) Token: 0x0600E14C RID: 57676 RVA: 0x0006D6CA File Offset: 0x0006B8CA
			public unsafe ItemSelector.Option opt
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_opt);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector.Option>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_opt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004587 RID: 17799
			// (get) Token: 0x0600E14D RID: 57677 RVA: 0x00356E04 File Offset: 0x00355004
			// (set) Token: 0x0600E14E RID: 57678 RVA: 0x0006D6E9 File Offset: 0x0006B8E9
			public unsafe ItemSelector __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009715 RID: 38677
			private static readonly System.IntPtr NativeFieldInfoPtr_opt;

			// Token: 0x04009716 RID: 38678
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009717 RID: 38679
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009718 RID: 38680
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateOptions_b__0_Internal_Void_0;

			// Token: 0x04009719 RID: 38681
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_BaseEventData_0;

			// Token: 0x0400971A RID: 38682
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_BaseEventData_0;
		}
	}
}
