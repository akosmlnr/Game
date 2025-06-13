using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management.UI;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003C4 RID: 964
	public class ManagementInterface : Singleton<ManagementInterface>
	{
		// Token: 0x06004A66 RID: 19046 RVA: 0x0016C960 File Offset: 0x0016AB60
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementInterface()
		{
			Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr);
			ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "PANEL_SLIDE_TIME");
			ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<EquippedClipboard>k__BackingField");
			ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "NothingSelectedLabel");
			ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "DifferentTypesSelectedLabel");
			ManagementInterface.NativeFieldInfoPtr_PanelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "PanelContainer");
			ManagementInterface.NativeFieldInfoPtr_MainScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "MainScreen");
			ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ItemSelectorScreen");
			ManagementInterface.NativeFieldInfoPtr_NPCSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "NPCSelector");
			ManagementInterface.NativeFieldInfoPtr_ObjectSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ObjectSelector");
			ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "RecipeSelectorScreen");
			ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "TransitEntitySelector");
			ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ConfigPanelPrefabs");
			ManagementInterface.NativeFieldInfoPtr_Configurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "Configurables");
			ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "areConfigurablesUniform");
			ManagementInterface.NativeFieldInfoPtr_loadedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "loadedPanel");
			ManagementInterface.NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672601);
			ManagementInterface.NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672602);
			ManagementInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672603);
			ManagementInterface.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672604);
			ManagementInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672605);
			ManagementInterface.NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672606);
			ManagementInterface.NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672607);
			ManagementInterface.NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672608);
			ManagementInterface.NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672609);
			ManagementInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672610);
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06004A67 RID: 19047 RVA: 0x0016CB84 File Offset: 0x0016AD84
		// (set) Token: 0x06004A68 RID: 19048 RVA: 0x0016CBC4 File Offset: 0x0016ADC4
		public unsafe ManagementClipboard_Equippable EquippedClipboard
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard_Equippable>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x0016CC08 File Offset: 0x0016AE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167393, XrefRangeEnd = 167396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x0016CC44 File Offset: 0x0016AE44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167433, RefRangeEnd = 167434, XrefRangeStart = 167396, XrefRangeEnd = 167433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<IConfigurable> configurables, ManagementClipboard_Equippable _equippedClipboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurables);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_equippedClipboard);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x0016CC98 File Offset: 0x0016AE98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167447, RefRangeEnd = 167448, XrefRangeStart = 167434, XrefRangeEnd = 167447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool preserveState = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref preserveState;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x0016CCD8 File Offset: 0x0016AED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167448, XrefRangeEnd = 167454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMainLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x0016CD0C File Offset: 0x0016AF0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167515, RefRangeEnd = 167516, XrefRangeStart = 167454, XrefRangeEnd = 167515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeConfigPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x0016CD40 File Offset: 0x0016AF40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167525, RefRangeEnd = 167527, XrefRangeStart = 167516, XrefRangeEnd = 167525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyConfigPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x0016CD74 File Offset: 0x0016AF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167527, XrefRangeEnd = 167540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigPanel GetConfigPanelPrefab(EConfigurableType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr2) : null;
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x0016CDC0 File Offset: 0x0016AFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167540, XrefRangeEnd = 167550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x00023ABC File Offset: 0x00021CBC
		public ManagementInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x0016CDFC File Offset: 0x0016AFFC
		// (set) Token: 0x06004A73 RID: 19059 RVA: 0x00023AC5 File Offset: 0x00021CC5
		public unsafe static float PANEL_SLIDE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06004A74 RID: 19060 RVA: 0x0016CE18 File Offset: 0x0016B018
		// (set) Token: 0x06004A75 RID: 19061 RVA: 0x00023AD3 File Offset: 0x00021CD3
		public unsafe ManagementClipboard_Equippable _EquippedClipboard_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard_Equippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06004A76 RID: 19062 RVA: 0x0016CE48 File Offset: 0x0016B048
		// (set) Token: 0x06004A77 RID: 19063 RVA: 0x00023AF2 File Offset: 0x00021CF2
		public unsafe TextMeshProUGUI NothingSelectedLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06004A78 RID: 19064 RVA: 0x0016CE78 File Offset: 0x0016B078
		// (set) Token: 0x06004A79 RID: 19065 RVA: 0x00023B11 File Offset: 0x00021D11
		public unsafe TextMeshProUGUI DifferentTypesSelectedLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06004A7A RID: 19066 RVA: 0x0016CEA8 File Offset: 0x0016B0A8
		// (set) Token: 0x06004A7B RID: 19067 RVA: 0x00023B30 File Offset: 0x00021D30
		public unsafe RectTransform PanelContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_PanelContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_PanelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x0016CED8 File Offset: 0x0016B0D8
		// (set) Token: 0x06004A7D RID: 19069 RVA: 0x00023B4F File Offset: 0x00021D4F
		public unsafe ClipboardScreen MainScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_MainScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardScreen>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_MainScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06004A7E RID: 19070 RVA: 0x0016CF08 File Offset: 0x0016B108
		// (set) Token: 0x06004A7F RID: 19071 RVA: 0x00023B6E File Offset: 0x00021D6E
		public unsafe ItemSelector ItemSelectorScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06004A80 RID: 19072 RVA: 0x0016CF38 File Offset: 0x0016B138
		// (set) Token: 0x06004A81 RID: 19073 RVA: 0x00023B8D File Offset: 0x00021D8D
		public unsafe NPCSelector NPCSelector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NPCSelector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSelector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NPCSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06004A82 RID: 19074 RVA: 0x0016CF68 File Offset: 0x0016B168
		// (set) Token: 0x06004A83 RID: 19075 RVA: 0x00023BAC File Offset: 0x00021DAC
		public unsafe Il2CppScheduleOne.UI.Management.ObjectSelector ObjectSelector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ObjectSelector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.UI.Management.ObjectSelector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ObjectSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06004A84 RID: 19076 RVA: 0x0016CF98 File Offset: 0x0016B198
		// (set) Token: 0x06004A85 RID: 19077 RVA: 0x00023BCB File Offset: 0x00021DCB
		public unsafe RecipeSelector RecipeSelectorScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06004A86 RID: 19078 RVA: 0x0016CFC8 File Offset: 0x0016B1C8
		// (set) Token: 0x06004A87 RID: 19079 RVA: 0x00023BEA File Offset: 0x00021DEA
		public unsafe TransitEntitySelector TransitEntitySelector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitEntitySelector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06004A88 RID: 19080 RVA: 0x0016CFF8 File Offset: 0x0016B1F8
		// (set) Token: 0x06004A89 RID: 19081 RVA: 0x00023C09 File Offset: 0x00021E09
		public unsafe Il2CppReferenceArray<ManagementInterface.ConfigurableTypePanel> ConfigPanelPrefabs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ManagementInterface.ConfigurableTypePanel>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06004A8A RID: 19082 RVA: 0x0016D028 File Offset: 0x0016B228
		// (set) Token: 0x06004A8B RID: 19083 RVA: 0x00023C28 File Offset: 0x00021E28
		public unsafe List<IConfigurable> Configurables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_Configurables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_Configurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06004A8C RID: 19084 RVA: 0x0016D058 File Offset: 0x0016B258
		// (set) Token: 0x06004A8D RID: 19085 RVA: 0x00023C47 File Offset: 0x00021E47
		public unsafe bool areConfigurablesUniform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform)) = value;
			}
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06004A8E RID: 19086 RVA: 0x0016D080 File Offset: 0x0016B280
		// (set) Token: 0x06004A8F RID: 19087 RVA: 0x00023C62 File Offset: 0x00021E62
		public unsafe ConfigPanel loadedPanel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_loadedPanel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_loadedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400322B RID: 12843
		private static readonly System.IntPtr NativeFieldInfoPtr_PANEL_SLIDE_TIME;

		// Token: 0x0400322C RID: 12844
		private static readonly System.IntPtr NativeFieldInfoPtr__EquippedClipboard_k__BackingField;

		// Token: 0x0400322D RID: 12845
		private static readonly System.IntPtr NativeFieldInfoPtr_NothingSelectedLabel;

		// Token: 0x0400322E RID: 12846
		private static readonly System.IntPtr NativeFieldInfoPtr_DifferentTypesSelectedLabel;

		// Token: 0x0400322F RID: 12847
		private static readonly System.IntPtr NativeFieldInfoPtr_PanelContainer;

		// Token: 0x04003230 RID: 12848
		private static readonly System.IntPtr NativeFieldInfoPtr_MainScreen;

		// Token: 0x04003231 RID: 12849
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemSelectorScreen;

		// Token: 0x04003232 RID: 12850
		private static readonly System.IntPtr NativeFieldInfoPtr_NPCSelector;

		// Token: 0x04003233 RID: 12851
		private static readonly System.IntPtr NativeFieldInfoPtr_ObjectSelector;

		// Token: 0x04003234 RID: 12852
		private static readonly System.IntPtr NativeFieldInfoPtr_RecipeSelectorScreen;

		// Token: 0x04003235 RID: 12853
		private static readonly System.IntPtr NativeFieldInfoPtr_TransitEntitySelector;

		// Token: 0x04003236 RID: 12854
		private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPanelPrefabs;

		// Token: 0x04003237 RID: 12855
		private static readonly System.IntPtr NativeFieldInfoPtr_Configurables;

		// Token: 0x04003238 RID: 12856
		private static readonly System.IntPtr NativeFieldInfoPtr_areConfigurablesUniform;

		// Token: 0x04003239 RID: 12857
		private static readonly System.IntPtr NativeFieldInfoPtr_loadedPanel;

		// Token: 0x0400323A RID: 12858
		private static readonly System.IntPtr NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0;

		// Token: 0x0400323B RID: 12859
		private static readonly System.IntPtr NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0;

		// Token: 0x0400323C RID: 12860
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400323D RID: 12861
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0;

		// Token: 0x0400323E RID: 12862
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x0400323F RID: 12863
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0;

		// Token: 0x04003240 RID: 12864
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0;

		// Token: 0x04003241 RID: 12865
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0;

		// Token: 0x04003242 RID: 12866
		private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0;

		// Token: 0x04003243 RID: 12867
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009C7 RID: 2503
		[System.Serializable]
		public class ConfigurableTypePanel : Il2CppSystem.Object
		{
			// Token: 0x0600CEF5 RID: 52981 RVA: 0x0032327C File Offset: 0x0032147C
			// Note: this type is marked as 'beforefieldinit'.
			static ConfigurableTypePanel()
			{
				Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ConfigurableTypePanel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr);
				ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, "Type");
				ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, "Panel");
				ManagementInterface.ConfigurableTypePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, 100672611);
			}

			// Token: 0x0600CEF6 RID: 52982 RVA: 0x003232E4 File Offset: 0x003214E4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConfigurableTypePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.ConfigurableTypePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEF7 RID: 52983 RVA: 0x0006451E File Offset: 0x0006271E
			public ConfigurableTypePanel(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004033 RID: 16435
			// (get) Token: 0x0600CEF8 RID: 52984 RVA: 0x00323320 File Offset: 0x00321520
			// (set) Token: 0x0600CEF9 RID: 52985 RVA: 0x00064527 File Offset: 0x00062727
			public unsafe EConfigurableType Type
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x17004034 RID: 16436
			// (get) Token: 0x0600CEFA RID: 52986 RVA: 0x00323348 File Offset: 0x00321548
			// (set) Token: 0x0600CEFB RID: 52987 RVA: 0x00064542 File Offset: 0x00062742
			public unsafe ConfigPanel Panel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C14 RID: 35860
			private static readonly System.IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x04008C15 RID: 35861
			private static readonly System.IntPtr NativeFieldInfoPtr_Panel;

			// Token: 0x04008C16 RID: 35862
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009C8 RID: 2504
		[ObfuscatedName("ScheduleOne.Management.ManagementInterface+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CEFC RID: 52988 RVA: 0x00323378 File Offset: 0x00321578
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr);
				ManagementInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, "<>9");
				ManagementInterface.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, "<>9__23_0");
				ManagementInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, 100672613);
				ManagementInterface.__c.NativeMethodInfoPtr__InitializeConfigPanel_b__23_0_Internal_EntityConfiguration_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, 100672614);
			}

			// Token: 0x0600CEFD RID: 52989 RVA: 0x003233F4 File Offset: 0x003215F4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEFE RID: 52990 RVA: 0x00323430 File Offset: 0x00321630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167389, XrefRangeEnd = 167393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityConfiguration _InitializeConfigPanel_b__23_0(IConfigurable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c.NativeMethodInfoPtr__InitializeConfigPanel_b__23_0_Internal_EntityConfiguration_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}

			// Token: 0x0600CEFF RID: 52991 RVA: 0x00064561 File Offset: 0x00062761
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004035 RID: 16437
			// (get) Token: 0x0600CF00 RID: 52992 RVA: 0x00323480 File Offset: 0x00321680
			// (set) Token: 0x0600CF01 RID: 52993 RVA: 0x0006456A File Offset: 0x0006276A
			public unsafe static ManagementInterface.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004036 RID: 16438
			// (get) Token: 0x0600CF02 RID: 52994 RVA: 0x003234A8 File Offset: 0x003216A8
			// (set) Token: 0x0600CF03 RID: 52995 RVA: 0x0006457C File Offset: 0x0006277C
			public unsafe static Il2CppSystem.Func<IConfigurable, EntityConfiguration> __9__23_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementInterface.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<IConfigurable, EntityConfiguration>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementInterface.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C17 RID: 35863
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008C18 RID: 35864
			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04008C19 RID: 35865
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C1A RID: 35866
			private static readonly System.IntPtr NativeMethodInfoPtr__InitializeConfigPanel_b__23_0_Internal_EntityConfiguration_IConfigurable_0;
		}

		// Token: 0x020009C9 RID: 2505
		[ObfuscatedName("ScheduleOne.Management.ManagementInterface+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF04 RID: 52996 RVA: 0x003234D0 File Offset: 0x003216D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr);
				ManagementInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr, "type");
				ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr, 100672615);
				ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr, 100672616);
			}

			// Token: 0x0600CF05 RID: 52997 RVA: 0x00323538 File Offset: 0x00321738
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF06 RID: 52998 RVA: 0x00323574 File Offset: 0x00321774
			[CallerCount(0)]
			public unsafe bool _GetConfigPanelPrefab_b__0(ManagementInterface.ConfigurableTypePanel x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CF07 RID: 52999 RVA: 0x0006458E File Offset: 0x0006278E
			public __c__DisplayClass25_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004037 RID: 16439
			// (get) Token: 0x0600CF08 RID: 53000 RVA: 0x003235C4 File Offset: 0x003217C4
			// (set) Token: 0x0600CF09 RID: 53001 RVA: 0x00064597 File Offset: 0x00062797
			public unsafe EConfigurableType type
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04008C1B RID: 35867
			private static readonly System.IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008C1C RID: 35868
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C1D RID: 35869
			private static readonly System.IntPtr NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0;
		}
	}
}
