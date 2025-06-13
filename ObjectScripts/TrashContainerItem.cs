using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.Trash;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200075B RID: 1883
	public class TrashContainerItem : GridItem
	{
		// Token: 0x0600AA9C RID: 43676 RVA: 0x002ABDB0 File Offset: 0x002A9FB0
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerItem()
		{
			Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "TrashContainerItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr);
			TrashContainerItem.NativeFieldInfoPtr_MAX_VERTICAL_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "MAX_VERTICAL_OFFSET");
			TrashContainerItem.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "Container");
			TrashContainerItem.NativeFieldInfoPtr_Flies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "Flies");
			TrashContainerItem.NativeFieldInfoPtr_TrashAddedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "TrashAddedSound");
			TrashContainerItem.NativeFieldInfoPtr_PickupAreaProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "PickupAreaProjector");
			TrashContainerItem.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "accessPoints");
			TrashContainerItem.NativeFieldInfoPtr_UsableByCleaners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "UsableByCleaners");
			TrashContainerItem.NativeFieldInfoPtr_PickupSquareWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "PickupSquareWidth");
			TrashContainerItem.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<InputSlots>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<OutputSlots>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<Selectable>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr_TrashItemsInRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "TrashItemsInRadius");
			TrashContainerItem.NativeFieldInfoPtr_TrashBagsInRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "TrashBagsInRadius");
			TrashContainerItem.NativeFieldInfoPtr_calculatedPickupRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "calculatedPickupRadius");
			TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted");
			TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted");
			TrashContainerItem.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684283);
			TrashContainerItem.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684284);
			TrashContainerItem.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684285);
			TrashContainerItem.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684286);
			TrashContainerItem.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684287);
			TrashContainerItem.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684288);
			TrashContainerItem.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684289);
			TrashContainerItem.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684290);
			TrashContainerItem.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684291);
			TrashContainerItem.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684292);
			TrashContainerItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684293);
			TrashContainerItem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684294);
			TrashContainerItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684295);
			TrashContainerItem.NativeMethodInfoPtr_TrashLevelChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684296);
			TrashContainerItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684297);
			TrashContainerItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684298);
			TrashContainerItem.NativeMethodInfoPtr_TrashAdded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684299);
			TrashContainerItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684300);
			TrashContainerItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684301);
			TrashContainerItem.NativeMethodInfoPtr_CheckTrashItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684302);
			TrashContainerItem.NativeMethodInfoPtr_AddTrashToRadius_Private_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684303);
			TrashContainerItem.NativeMethodInfoPtr_AddTrashBagToRadius_Private_Void_TrashBag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684304);
			TrashContainerItem.NativeMethodInfoPtr_RemoveTrashItemFromRadius_Private_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684305);
			TrashContainerItem.NativeMethodInfoPtr_RemoveTrashBagFromRadius_Private_Void_TrashBag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684306);
			TrashContainerItem.NativeMethodInfoPtr_IsTrashValid_Private_Boolean_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684307);
			TrashContainerItem.NativeMethodInfoPtr_IsPointInPickupZone_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684308);
			TrashContainerItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684309);
			TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684310);
			TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684311);
			TrashContainerItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684312);
			TrashContainerItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100684313);
		}

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x0600AA9D RID: 43677 RVA: 0x002AC1A0 File Offset: 0x002AA3A0
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296834, XrefRangeEnd = 296835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0600AA9E RID: 43678 RVA: 0x002AC1D8 File Offset: 0x002AA3D8
		// (set) Token: 0x0600AA9F RID: 43679 RVA: 0x002AC218 File Offset: 0x002AA418
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0600AAA0 RID: 43680 RVA: 0x002AC25C File Offset: 0x002AA45C
		// (set) Token: 0x0600AAA1 RID: 43681 RVA: 0x002AC29C File Offset: 0x002AA49C
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296835, XrefRangeEnd = 296836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600AAA2 RID: 43682 RVA: 0x002AC2E0 File Offset: 0x002AA4E0
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 51237, RefRangeEnd = 51239, XrefRangeStart = 51237, XrefRangeEnd = 51239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600AAA3 RID: 43683 RVA: 0x002AC320 File Offset: 0x002AA520
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600AAA4 RID: 43684 RVA: 0x002AC360 File Offset: 0x002AA560
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0600AAA5 RID: 43685 RVA: 0x002AC39C File Offset: 0x002AA59C
		// (set) Token: 0x0600AAA6 RID: 43686 RVA: 0x002AC3D8 File Offset: 0x002AA5D8
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600AAA7 RID: 43687 RVA: 0x002AC418 File Offset: 0x002AA618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296836, XrefRangeEnd = 296842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAA8 RID: 43688 RVA: 0x002AC454 File Offset: 0x002AA654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296842, XrefRangeEnd = 296860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAA9 RID: 43689 RVA: 0x002AC490 File Offset: 0x002AA690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296860, XrefRangeEnd = 296865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAAA RID: 43690 RVA: 0x002AC520 File Offset: 0x002AA720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296865, XrefRangeEnd = 296868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrashLevelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_TrashLevelChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAAB RID: 43691 RVA: 0x002AC554 File Offset: 0x002AA754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296868, XrefRangeEnd = 296874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AAAC RID: 43692 RVA: 0x002AC5B8 File Offset: 0x002AA7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296874, XrefRangeEnd = 296879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr2) : null;
		}

		// Token: 0x0600AAAD RID: 43693 RVA: 0x002AC604 File Offset: 0x002AA804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296879, XrefRangeEnd = 296889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrashAdded(string trashID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_TrashAdded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAAE RID: 43694 RVA: 0x002AC648 File Offset: 0x002AA848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296889, XrefRangeEnd = 296892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAAF RID: 43695 RVA: 0x002AC694 File Offset: 0x002AA894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296892, XrefRangeEnd = 296895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAB0 RID: 43696 RVA: 0x002AC6D0 File Offset: 0x002AA8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296895, XrefRangeEnd = 296930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTrashItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_CheckTrashItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAB1 RID: 43697 RVA: 0x002AC704 File Offset: 0x002AA904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296952, RefRangeEnd = 296953, XrefRangeStart = 296930, XrefRangeEnd = 296952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrashToRadius(TrashItem trashItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItem);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_AddTrashToRadius_Private_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAB2 RID: 43698 RVA: 0x002AC748 File Offset: 0x002AA948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296974, RefRangeEnd = 296975, XrefRangeStart = 296953, XrefRangeEnd = 296974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrashBagToRadius(TrashBag trashBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashBag);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_AddTrashBagToRadius_Private_Void_TrashBag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAB3 RID: 43699 RVA: 0x002AC78C File Offset: 0x002AA98C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297000, RefRangeEnd = 297001, XrefRangeStart = 296975, XrefRangeEnd = 297000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrashItemFromRadius(TrashItem trashItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItem);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_RemoveTrashItemFromRadius_Private_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAB4 RID: 43700 RVA: 0x002AC7D0 File Offset: 0x002AA9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297001, XrefRangeEnd = 297020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrashBagFromRadius(TrashBag trashBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashBag);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_RemoveTrashBagFromRadius_Private_Void_TrashBag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAB5 RID: 43701 RVA: 0x002AC814 File Offset: 0x002AAA14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297031, RefRangeEnd = 297033, XrefRangeStart = 297020, XrefRangeEnd = 297031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTrashValid(TrashItem trashItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItem);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_IsTrashValid_Private_Boolean_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AAB6 RID: 43702 RVA: 0x002AC864 File Offset: 0x002AAA64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297039, RefRangeEnd = 297041, XrefRangeStart = 297033, XrefRangeEnd = 297039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInPickupZone(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_IsPointInPickupZone_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AAB7 RID: 43703 RVA: 0x002AC8B0 File Offset: 0x002AAAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297041, XrefRangeEnd = 297068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAB8 RID: 43704 RVA: 0x002AC8EC File Offset: 0x002AAAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297068, XrefRangeEnd = 297069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAB9 RID: 43705 RVA: 0x002AC928 File Offset: 0x002AAB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297069, XrefRangeEnd = 297070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AABA RID: 43706 RVA: 0x002AC964 File Offset: 0x002AAB64
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AABB RID: 43707 RVA: 0x002AC9A0 File Offset: 0x002AABA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297070, XrefRangeEnd = 297075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AABC RID: 43708 RVA: 0x00053D83 File Offset: 0x00051F83
		public TrashContainerItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0600AABD RID: 43709 RVA: 0x002AC9DC File Offset: 0x002AABDC
		// (set) Token: 0x0600AABE RID: 43710 RVA: 0x00053D8C File Offset: 0x00051F8C
		public unsafe static float MAX_VERTICAL_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashContainerItem.NativeFieldInfoPtr_MAX_VERTICAL_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashContainerItem.NativeFieldInfoPtr_MAX_VERTICAL_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0600AABF RID: 43711 RVA: 0x002AC9F8 File Offset: 0x002AABF8
		// (set) Token: 0x0600AAC0 RID: 43712 RVA: 0x00053D9A File Offset: 0x00051F9A
		public unsafe TrashContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x0600AAC1 RID: 43713 RVA: 0x002ACA28 File Offset: 0x002AAC28
		// (set) Token: 0x0600AAC2 RID: 43714 RVA: 0x00053DB9 File Offset: 0x00051FB9
		public unsafe ParticleSystem Flies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Flies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Flies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x0600AAC3 RID: 43715 RVA: 0x002ACA58 File Offset: 0x002AAC58
		// (set) Token: 0x0600AAC4 RID: 43716 RVA: 0x00053DD8 File Offset: 0x00051FD8
		public unsafe AudioSourceController TrashAddedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashAddedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashAddedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0600AAC5 RID: 43717 RVA: 0x002ACA88 File Offset: 0x002AAC88
		// (set) Token: 0x0600AAC6 RID: 43718 RVA: 0x00053DF7 File Offset: 0x00051FF7
		public unsafe DecalProjector PickupAreaProjector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupAreaProjector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupAreaProjector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0600AAC7 RID: 43719 RVA: 0x002ACAB8 File Offset: 0x002AACB8
		// (set) Token: 0x0600AAC8 RID: 43720 RVA: 0x00053E16 File Offset: 0x00052016
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0600AAC9 RID: 43721 RVA: 0x002ACAE8 File Offset: 0x002AACE8
		// (set) Token: 0x0600AACA RID: 43722 RVA: 0x00053E35 File Offset: 0x00052035
		public unsafe bool UsableByCleaners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_UsableByCleaners);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_UsableByCleaners)) = value;
			}
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0600AACB RID: 43723 RVA: 0x002ACB10 File Offset: 0x002AAD10
		// (set) Token: 0x0600AACC RID: 43724 RVA: 0x00053E50 File Offset: 0x00052050
		public unsafe float PickupSquareWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupSquareWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupSquareWidth)) = value;
			}
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0600AACD RID: 43725 RVA: 0x002ACB38 File Offset: 0x002AAD38
		// (set) Token: 0x0600AACE RID: 43726 RVA: 0x00053E6B File Offset: 0x0005206B
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0600AACF RID: 43727 RVA: 0x002ACB68 File Offset: 0x002AAD68
		// (set) Token: 0x0600AAD0 RID: 43728 RVA: 0x00053E8A File Offset: 0x0005208A
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600AAD1 RID: 43729 RVA: 0x002ACB98 File Offset: 0x002AAD98
		// (set) Token: 0x0600AAD2 RID: 43730 RVA: 0x00053EA9 File Offset: 0x000520A9
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600AAD3 RID: 43731 RVA: 0x002ACBC0 File Offset: 0x002AADC0
		// (set) Token: 0x0600AAD4 RID: 43732 RVA: 0x00053EC4 File Offset: 0x000520C4
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0600AAD5 RID: 43733 RVA: 0x002ACBE8 File Offset: 0x002AADE8
		// (set) Token: 0x0600AAD6 RID: 43734 RVA: 0x00053EDF File Offset: 0x000520DF
		public unsafe List<TrashItem> TrashItemsInRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashItemsInRadius);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashItemsInRadius), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0600AAD7 RID: 43735 RVA: 0x002ACC18 File Offset: 0x002AAE18
		// (set) Token: 0x0600AAD8 RID: 43736 RVA: 0x00053EFE File Offset: 0x000520FE
		public unsafe List<TrashBag> TrashBagsInRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashBagsInRadius);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashBag>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashBagsInRadius), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0600AAD9 RID: 43737 RVA: 0x002ACC48 File Offset: 0x002AAE48
		// (set) Token: 0x0600AADA RID: 43738 RVA: 0x00053F1D File Offset: 0x0005211D
		public unsafe float calculatedPickupRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_calculatedPickupRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_calculatedPickupRadius)) = value;
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0600AADB RID: 43739 RVA: 0x002ACC70 File Offset: 0x002AAE70
		// (set) Token: 0x0600AADC RID: 43740 RVA: 0x00053F38 File Offset: 0x00052138
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0600AADD RID: 43741 RVA: 0x002ACC98 File Offset: 0x002AAE98
		// (set) Token: 0x0600AADE RID: 43742 RVA: 0x00053F53 File Offset: 0x00052153
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007279 RID: 29305
		private static readonly IntPtr NativeFieldInfoPtr_MAX_VERTICAL_OFFSET;

		// Token: 0x0400727A RID: 29306
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400727B RID: 29307
		private static readonly IntPtr NativeFieldInfoPtr_Flies;

		// Token: 0x0400727C RID: 29308
		private static readonly IntPtr NativeFieldInfoPtr_TrashAddedSound;

		// Token: 0x0400727D RID: 29309
		private static readonly IntPtr NativeFieldInfoPtr_PickupAreaProjector;

		// Token: 0x0400727E RID: 29310
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x0400727F RID: 29311
		private static readonly IntPtr NativeFieldInfoPtr_UsableByCleaners;

		// Token: 0x04007280 RID: 29312
		private static readonly IntPtr NativeFieldInfoPtr_PickupSquareWidth;

		// Token: 0x04007281 RID: 29313
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x04007282 RID: 29314
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x04007283 RID: 29315
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x04007284 RID: 29316
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x04007285 RID: 29317
		private static readonly IntPtr NativeFieldInfoPtr_TrashItemsInRadius;

		// Token: 0x04007286 RID: 29318
		private static readonly IntPtr NativeFieldInfoPtr_TrashBagsInRadius;

		// Token: 0x04007287 RID: 29319
		private static readonly IntPtr NativeFieldInfoPtr_calculatedPickupRadius;

		// Token: 0x04007288 RID: 29320
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007289 RID: 29321
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400728A RID: 29322
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400728B RID: 29323
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400728C RID: 29324
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400728D RID: 29325
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400728E RID: 29326
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400728F RID: 29327
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04007290 RID: 29328
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04007291 RID: 29329
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007292 RID: 29330
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007293 RID: 29331
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04007294 RID: 29332
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04007295 RID: 29333
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04007296 RID: 29334
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04007297 RID: 29335
		private static readonly IntPtr NativeMethodInfoPtr_TrashLevelChanged_Private_Void_0;

		// Token: 0x04007298 RID: 29336
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04007299 RID: 29337
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x0400729A RID: 29338
		private static readonly IntPtr NativeMethodInfoPtr_TrashAdded_Private_Void_String_0;

		// Token: 0x0400729B RID: 29339
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Virtual_Void_Color_0;

		// Token: 0x0400729C RID: 29340
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Virtual_Void_0;

		// Token: 0x0400729D RID: 29341
		private static readonly IntPtr NativeMethodInfoPtr_CheckTrashItems_Private_Void_0;

		// Token: 0x0400729E RID: 29342
		private static readonly IntPtr NativeMethodInfoPtr_AddTrashToRadius_Private_Void_TrashItem_0;

		// Token: 0x0400729F RID: 29343
		private static readonly IntPtr NativeMethodInfoPtr_AddTrashBagToRadius_Private_Void_TrashBag_0;

		// Token: 0x040072A0 RID: 29344
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrashItemFromRadius_Private_Void_TrashItem_0;

		// Token: 0x040072A1 RID: 29345
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrashBagFromRadius_Private_Void_TrashBag_0;

		// Token: 0x040072A2 RID: 29346
		private static readonly IntPtr NativeMethodInfoPtr_IsTrashValid_Private_Boolean_TrashItem_0;

		// Token: 0x040072A3 RID: 29347
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInPickupZone_Public_Boolean_Vector3_0;

		// Token: 0x040072A4 RID: 29348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040072A5 RID: 29349
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040072A6 RID: 29350
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040072A7 RID: 29351
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040072A8 RID: 29352
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
