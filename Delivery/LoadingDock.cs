using System;
using Il2CppEPOOutline;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200049F RID: 1183
	public class LoadingDock : MonoBehaviour
	{
		// Token: 0x06006563 RID: 25955 RVA: 0x001CD914 File Offset: 0x001CBB14
		// Note: this type is marked as 'beforefieldinit'.
		static LoadingDock()
		{
			Il2CppClassPointerStore<LoadingDock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "LoadingDock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr);
			LoadingDock.NativeFieldInfoPtr__DynamicOccupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<DynamicOccupant>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__StaticOccupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<StaticOccupant>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<GUID>k__BackingField");
			LoadingDock.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "BakedGUID");
			LoadingDock.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<InputSlots>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<OutputSlots>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<Selectable>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__IsDestroyed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<IsDestroyed>k__BackingField");
			LoadingDock.NativeFieldInfoPtr_ParentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "ParentProperty");
			LoadingDock.NativeFieldInfoPtr_VehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "VehicleDetector");
			LoadingDock.NativeFieldInfoPtr_Parking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "Parking");
			LoadingDock.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "uiPoint");
			LoadingDock.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "accessPoints");
			LoadingDock.NativeFieldInfoPtr_OutlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "OutlineRenderers");
			LoadingDock.NativeFieldInfoPtr_OutlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "OutlineEffect");
			LoadingDock.NativeMethodInfoPtr_get_DynamicOccupant_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676248);
			LoadingDock.NativeMethodInfoPtr_set_DynamicOccupant_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676249);
			LoadingDock.NativeMethodInfoPtr_get_StaticOccupant_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676250);
			LoadingDock.NativeMethodInfoPtr_set_StaticOccupant_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676251);
			LoadingDock.NativeMethodInfoPtr_get_IsInUse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676252);
			LoadingDock.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676253);
			LoadingDock.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676254);
			LoadingDock.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676255);
			LoadingDock.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676256);
			LoadingDock.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676257);
			LoadingDock.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676258);
			LoadingDock.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676259);
			LoadingDock.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676260);
			LoadingDock.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676261);
			LoadingDock.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676262);
			LoadingDock.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676263);
			LoadingDock.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676264);
			LoadingDock.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676265);
			LoadingDock.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676266);
			LoadingDock.NativeMethodInfoPtr_set_IsDestroyed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676267);
			LoadingDock.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676268);
			LoadingDock.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676269);
			LoadingDock.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676270);
			LoadingDock.NativeMethodInfoPtr_RefreshOccupant_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676271);
			LoadingDock.NativeMethodInfoPtr_SetOccupant_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676272);
			LoadingDock.NativeMethodInfoPtr_SetStaticOccupant_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676273);
			LoadingDock.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676274);
			LoadingDock.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676275);
			LoadingDock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100676276);
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06006564 RID: 25956 RVA: 0x001CDCC8 File Offset: 0x001CBEC8
		// (set) Token: 0x06006565 RID: 25957 RVA: 0x001CDD08 File Offset: 0x001CBF08
		public unsafe LandVehicle DynamicOccupant
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_DynamicOccupant_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_DynamicOccupant_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06006566 RID: 25958 RVA: 0x001CDD4C File Offset: 0x001CBF4C
		// (set) Token: 0x06006567 RID: 25959 RVA: 0x001CDD8C File Offset: 0x001CBF8C
		public unsafe LandVehicle StaticOccupant
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_StaticOccupant_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_StaticOccupant_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06006568 RID: 25960 RVA: 0x001CDDD0 File Offset: 0x001CBFD0
		public unsafe bool IsInUse
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208028, XrefRangeEnd = 208032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_IsInUse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06006569 RID: 25961 RVA: 0x001CDE0C File Offset: 0x001CC00C
		// (set) Token: 0x0600656A RID: 25962 RVA: 0x001CDE48 File Offset: 0x001CC048
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x001CDE88 File Offset: 0x001CC088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208032, XrefRangeEnd = 208035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x0600656C RID: 25964 RVA: 0x001CDEBC File Offset: 0x001CC0BC
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208035, XrefRangeEnd = 208042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x0600656D RID: 25965 RVA: 0x001CDEF4 File Offset: 0x001CC0F4
		// (set) Token: 0x0600656E RID: 25966 RVA: 0x001CDF34 File Offset: 0x001CC134
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x0600656F RID: 25967 RVA: 0x001CDF78 File Offset: 0x001CC178
		// (set) Token: 0x06006570 RID: 25968 RVA: 0x001CDFB8 File Offset: 0x001CC1B8
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06006571 RID: 25969 RVA: 0x001CDFFC File Offset: 0x001CC1FC
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48163, RefRangeEnd = 48164, XrefRangeStart = 48163, XrefRangeEnd = 48164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x06006572 RID: 25970 RVA: 0x001CE03C File Offset: 0x001CC23C
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x06006573 RID: 25971 RVA: 0x001CE07C File Offset: 0x001CC27C
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x06006574 RID: 25972 RVA: 0x001CE0B8 File Offset: 0x001CC2B8
		// (set) Token: 0x06006575 RID: 25973 RVA: 0x001CE0F4 File Offset: 0x001CC2F4
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06006576 RID: 25974 RVA: 0x001CE134 File Offset: 0x001CC334
		// (set) Token: 0x06006577 RID: 25975 RVA: 0x001CE170 File Offset: 0x001CC370
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_IsDestroyed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x001CE1B0 File Offset: 0x001CC3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208042, XrefRangeEnd = 208047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x001CE1E4 File Offset: 0x001CC3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208047, XrefRangeEnd = 208051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x001CE218 File Offset: 0x001CC418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208051, XrefRangeEnd = 208055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x001CE258 File Offset: 0x001CC458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208055, XrefRangeEnd = 208088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshOccupant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_RefreshOccupant_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x001CE28C File Offset: 0x001CC48C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208129, RefRangeEnd = 208130, XrefRangeStart = 208088, XrefRangeEnd = 208129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(LandVehicle occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetOccupant_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x001CE2D0 File Offset: 0x001CC4D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStaticOccupant(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetStaticOccupant_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x001CE314 File Offset: 0x001CC514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208130, XrefRangeEnd = 208171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x001CE360 File Offset: 0x001CC560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208171, XrefRangeEnd = 208176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x001CE39C File Offset: 0x001CC59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208176, XrefRangeEnd = 208192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadingDock() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x0002FB04 File Offset: 0x0002DD04
		public LoadingDock(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x06006582 RID: 25986 RVA: 0x001CE3D8 File Offset: 0x001CC5D8
		// (set) Token: 0x06006583 RID: 25987 RVA: 0x0002FB0D File Offset: 0x0002DD0D
		public unsafe LandVehicle _DynamicOccupant_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__DynamicOccupant_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__DynamicOccupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x06006584 RID: 25988 RVA: 0x001CE408 File Offset: 0x001CC608
		// (set) Token: 0x06006585 RID: 25989 RVA: 0x0002FB2C File Offset: 0x0002DD2C
		public unsafe LandVehicle _StaticOccupant_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__StaticOccupant_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__StaticOccupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x06006586 RID: 25990 RVA: 0x001CE438 File Offset: 0x001CC638
		// (set) Token: 0x06006587 RID: 25991 RVA: 0x0002FB4B File Offset: 0x0002DD4B
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x06006588 RID: 25992 RVA: 0x001CE460 File Offset: 0x001CC660
		// (set) Token: 0x06006589 RID: 25993 RVA: 0x0002FB66 File Offset: 0x0002DD66
		public unsafe string BakedGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x0600658A RID: 25994 RVA: 0x001CE488 File Offset: 0x001CC688
		// (set) Token: 0x0600658B RID: 25995 RVA: 0x0002FB85 File Offset: 0x0002DD85
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__InputSlots_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x0600658C RID: 25996 RVA: 0x001CE4B8 File Offset: 0x001CC6B8
		// (set) Token: 0x0600658D RID: 25997 RVA: 0x0002FBA4 File Offset: 0x0002DDA4
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x0600658E RID: 25998 RVA: 0x001CE4E8 File Offset: 0x001CC6E8
		// (set) Token: 0x0600658F RID: 25999 RVA: 0x0002FBC3 File Offset: 0x0002DDC3
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06006590 RID: 26000 RVA: 0x001CE510 File Offset: 0x001CC710
		// (set) Token: 0x06006591 RID: 26001 RVA: 0x0002FBDE File Offset: 0x0002DDDE
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x06006592 RID: 26002 RVA: 0x001CE538 File Offset: 0x001CC738
		// (set) Token: 0x06006593 RID: 26003 RVA: 0x0002FBF9 File Offset: 0x0002DDF9
		public unsafe bool _IsDestroyed_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsDestroyed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsDestroyed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x06006594 RID: 26004 RVA: 0x001CE560 File Offset: 0x001CC760
		// (set) Token: 0x06006595 RID: 26005 RVA: 0x0002FC14 File Offset: 0x0002DE14
		public unsafe Property ParentProperty
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_ParentProperty);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_ParentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x06006596 RID: 26006 RVA: 0x001CE590 File Offset: 0x001CC790
		// (set) Token: 0x06006597 RID: 26007 RVA: 0x0002FC33 File Offset: 0x0002DE33
		public unsafe VehicleDetector VehicleDetector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_VehicleDetector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_VehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x06006598 RID: 26008 RVA: 0x001CE5C0 File Offset: 0x001CC7C0
		// (set) Token: 0x06006599 RID: 26009 RVA: 0x0002FC52 File Offset: 0x0002DE52
		public unsafe ParkingLot Parking
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_Parking);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_Parking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x0600659A RID: 26010 RVA: 0x001CE5F0 File Offset: 0x001CC7F0
		// (set) Token: 0x0600659B RID: 26011 RVA: 0x0002FC71 File Offset: 0x0002DE71
		public unsafe Transform uiPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_uiPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x0600659C RID: 26012 RVA: 0x001CE620 File Offset: 0x001CC820
		// (set) Token: 0x0600659D RID: 26013 RVA: 0x0002FC90 File Offset: 0x0002DE90
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_accessPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x0600659E RID: 26014 RVA: 0x001CE650 File Offset: 0x001CC850
		// (set) Token: 0x0600659F RID: 26015 RVA: 0x0002FCAF File Offset: 0x0002DEAF
		public unsafe Il2CppReferenceArray<GameObject> OutlineRenderers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineRenderers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x060065A0 RID: 26016 RVA: 0x001CE680 File Offset: 0x001CC880
		// (set) Token: 0x060065A1 RID: 26017 RVA: 0x0002FCCE File Offset: 0x0002DECE
		public unsafe Outlinable OutlineEffect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineEffect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004534 RID: 17716
		private static readonly System.IntPtr NativeFieldInfoPtr__DynamicOccupant_k__BackingField;

		// Token: 0x04004535 RID: 17717
		private static readonly System.IntPtr NativeFieldInfoPtr__StaticOccupant_k__BackingField;

		// Token: 0x04004536 RID: 17718
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04004537 RID: 17719
		private static readonly System.IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04004538 RID: 17720
		private static readonly System.IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x04004539 RID: 17721
		private static readonly System.IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x0400453A RID: 17722
		private static readonly System.IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x0400453B RID: 17723
		private static readonly System.IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x0400453C RID: 17724
		private static readonly System.IntPtr NativeFieldInfoPtr__IsDestroyed_k__BackingField;

		// Token: 0x0400453D RID: 17725
		private static readonly System.IntPtr NativeFieldInfoPtr_ParentProperty;

		// Token: 0x0400453E RID: 17726
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleDetector;

		// Token: 0x0400453F RID: 17727
		private static readonly System.IntPtr NativeFieldInfoPtr_Parking;

		// Token: 0x04004540 RID: 17728
		private static readonly System.IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04004541 RID: 17729
		private static readonly System.IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x04004542 RID: 17730
		private static readonly System.IntPtr NativeFieldInfoPtr_OutlineRenderers;

		// Token: 0x04004543 RID: 17731
		private static readonly System.IntPtr NativeFieldInfoPtr_OutlineEffect;

		// Token: 0x04004544 RID: 17732
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DynamicOccupant_Public_get_LandVehicle_0;

		// Token: 0x04004545 RID: 17733
		private static readonly System.IntPtr NativeMethodInfoPtr_set_DynamicOccupant_Private_set_Void_LandVehicle_0;

		// Token: 0x04004546 RID: 17734
		private static readonly System.IntPtr NativeMethodInfoPtr_get_StaticOccupant_Public_get_LandVehicle_0;

		// Token: 0x04004547 RID: 17735
		private static readonly System.IntPtr NativeMethodInfoPtr_set_StaticOccupant_Private_set_Void_LandVehicle_0;

		// Token: 0x04004548 RID: 17736
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInUse_Public_get_Boolean_0;

		// Token: 0x04004549 RID: 17737
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400454A RID: 17738
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400454B RID: 17739
		private static readonly System.IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x0400454C RID: 17740
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400454D RID: 17741
		private static readonly System.IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400454E RID: 17742
		private static readonly System.IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400454F RID: 17743
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04004550 RID: 17744
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04004551 RID: 17745
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04004552 RID: 17746
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04004553 RID: 17747
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004554 RID: 17748
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004555 RID: 17749
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04004556 RID: 17750
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004557 RID: 17751
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDestroyed_Public_set_Void_Boolean_0;

		// Token: 0x04004558 RID: 17752
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004559 RID: 17753
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400455A RID: 17754
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x0400455B RID: 17755
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshOccupant_Private_Void_0;

		// Token: 0x0400455C RID: 17756
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOccupant_Private_Void_LandVehicle_0;

		// Token: 0x0400455D RID: 17757
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStaticOccupant_Public_Void_LandVehicle_0;

		// Token: 0x0400455E RID: 17758
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0;

		// Token: 0x0400455F RID: 17759
		private static readonly System.IntPtr NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0;

		// Token: 0x04004560 RID: 17760
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
