using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200053E RID: 1342
	public class TrashBag_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06007667 RID: 30311 RVA: 0x0020605C File Offset: 0x0020425C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBag_Equippable()
		{
			Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashBag_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr);
			TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "TRASH_CONTAINER_INTERACT_DISTANCE");
			TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "BAG_TRASH_TIME");
			TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PICKUP_RANGE");
			TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PICKUP_AREA_RADIUS");
			TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "<IsBaggingTrash>k__BackingField");
			TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "<IsPickingUpTrash>k__BackingField");
			TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PickupLookMask");
			TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PickupAreaProjector");
			TrashBag_Equippable.NativeFieldInfoPtr_RustleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "RustleSound");
			TrashBag_Equippable.NativeFieldInfoPtr_BagSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "BagSound");
			TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_bagTrashTime");
			TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_baggedContainer");
			TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_pickupTrashTime");
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsHoveringTrash_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678274);
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678275);
			TrashBag_Equippable.NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678276);
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678277);
			TrashBag_Equippable.NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678278);
			TrashBag_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678279);
			TrashBag_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678280);
			TrashBag_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678281);
			TrashBag_Equippable.NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678282);
			TrashBag_Equippable.NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678283);
			TrashBag_Equippable.NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678284);
			TrashBag_Equippable.NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678285);
			TrashBag_Equippable.NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678286);
			TrashBag_Equippable.NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678287);
			TrashBag_Equippable.NativeMethodInfoPtr_StartPickup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678288);
			TrashBag_Equippable.NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678289);
			TrashBag_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100678290);
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x06007668 RID: 30312 RVA: 0x002062E4 File Offset: 0x002044E4
		public unsafe static bool IsHoveringTrash
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 231277, RefRangeEnd = 231278, XrefRangeStart = 231270, XrefRangeEnd = 231277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsHoveringTrash_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x06007669 RID: 30313 RVA: 0x00206314 File Offset: 0x00204514
		// (set) Token: 0x0600766A RID: 30314 RVA: 0x00206350 File Offset: 0x00204550
		public unsafe bool IsBaggingTrash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x0600766B RID: 30315 RVA: 0x00206390 File Offset: 0x00204590
		// (set) Token: 0x0600766C RID: 30316 RVA: 0x002063CC File Offset: 0x002045CC
		public unsafe bool IsPickingUpTrash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x0020640C File Offset: 0x0020460C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231278, XrefRangeEnd = 231306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x0020645C File Offset: 0x0020465C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231306, XrefRangeEnd = 231318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x00206498 File Offset: 0x00204698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231318, XrefRangeEnd = 231413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x002064D4 File Offset: 0x002046D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231430, RefRangeEnd = 231431, XrefRangeStart = 231413, XrefRangeEnd = 231430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainer GetHoveredTrashContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x00206514 File Offset: 0x00204714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 231436, RefRangeEnd = 231438, XrefRangeStart = 231431, XrefRangeEnd = 231436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RaycastLook(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hit;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x00206560 File Offset: 0x00204760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 231442, RefRangeEnd = 231444, XrefRangeStart = 231438, XrefRangeEnd = 231442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPickupLocationValid(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x002065AC File Offset: 0x002047AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 231470, RefRangeEnd = 231473, XrefRangeStart = 231444, XrefRangeEnd = 231470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<TrashItem> GetTrashItemsAtPoint(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr2) : null;
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x002065F8 File Offset: 0x002047F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231473, XrefRangeEnd = 231475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBagTrash(TrashContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007675 RID: 30325 RVA: 0x0020663C File Offset: 0x0020483C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231475, XrefRangeEnd = 231480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBagTrash(bool complete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref complete;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x0020667C File Offset: 0x0020487C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231480, XrefRangeEnd = 231481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StartPickup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x002066B0 File Offset: 0x002048B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231527, RefRangeEnd = 231528, XrefRangeStart = 231481, XrefRangeEnd = 231527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPickup(bool complete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref complete;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x002066F0 File Offset: 0x002048F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBag_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00037FEE File Offset: 0x000361EE
		public TrashBag_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x0600767A RID: 30330 RVA: 0x0020672C File Offset: 0x0020492C
		// (set) Token: 0x0600767B RID: 30331 RVA: 0x00037FF7 File Offset: 0x000361F7
		public unsafe static float TRASH_CONTAINER_INTERACT_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x0600767C RID: 30332 RVA: 0x00206748 File Offset: 0x00204948
		// (set) Token: 0x0600767D RID: 30333 RVA: 0x00038005 File Offset: 0x00036205
		public unsafe static float BAG_TRASH_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME, (void*)(&value));
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x0600767E RID: 30334 RVA: 0x00206764 File Offset: 0x00204964
		// (set) Token: 0x0600767F RID: 30335 RVA: 0x00038013 File Offset: 0x00036213
		public unsafe static float PICKUP_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x06007680 RID: 30336 RVA: 0x00206780 File Offset: 0x00204980
		// (set) Token: 0x06007681 RID: 30337 RVA: 0x00038021 File Offset: 0x00036221
		public unsafe static float PICKUP_AREA_RADIUS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS, (void*)(&value));
			}
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x06007682 RID: 30338 RVA: 0x0020679C File Offset: 0x0020499C
		// (set) Token: 0x06007683 RID: 30339 RVA: 0x0003802F File Offset: 0x0003622F
		public unsafe bool _IsBaggingTrash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField)) = value;
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x06007684 RID: 30340 RVA: 0x002067C4 File Offset: 0x002049C4
		// (set) Token: 0x06007685 RID: 30341 RVA: 0x0003804A File Offset: 0x0003624A
		public unsafe bool _IsPickingUpTrash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField)) = value;
			}
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x06007686 RID: 30342 RVA: 0x002067EC File Offset: 0x002049EC
		// (set) Token: 0x06007687 RID: 30343 RVA: 0x00038065 File Offset: 0x00036265
		public unsafe LayerMask PickupLookMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask)) = value;
			}
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x06007688 RID: 30344 RVA: 0x00206814 File Offset: 0x00204A14
		// (set) Token: 0x06007689 RID: 30345 RVA: 0x00038080 File Offset: 0x00036280
		public unsafe DecalProjector PickupAreaProjector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x0600768A RID: 30346 RVA: 0x00206844 File Offset: 0x00204A44
		// (set) Token: 0x0600768B RID: 30347 RVA: 0x0003809F File Offset: 0x0003629F
		public unsafe AudioSourceController RustleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_RustleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_RustleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x0600768C RID: 30348 RVA: 0x00206874 File Offset: 0x00204A74
		// (set) Token: 0x0600768D RID: 30349 RVA: 0x000380BE File Offset: 0x000362BE
		public unsafe AudioSourceController BagSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_BagSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_BagSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x0600768E RID: 30350 RVA: 0x002068A4 File Offset: 0x00204AA4
		// (set) Token: 0x0600768F RID: 30351 RVA: 0x000380DD File Offset: 0x000362DD
		public unsafe float _bagTrashTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime)) = value;
			}
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x06007690 RID: 30352 RVA: 0x002068CC File Offset: 0x00204ACC
		// (set) Token: 0x06007691 RID: 30353 RVA: 0x000380F8 File Offset: 0x000362F8
		public unsafe TrashContainer _baggedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x06007692 RID: 30354 RVA: 0x002068FC File Offset: 0x00204AFC
		// (set) Token: 0x06007693 RID: 30355 RVA: 0x00038117 File Offset: 0x00036317
		public unsafe float _pickupTrashTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime)) = value;
			}
		}

		// Token: 0x040050DA RID: 20698
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE;

		// Token: 0x040050DB RID: 20699
		private static readonly IntPtr NativeFieldInfoPtr_BAG_TRASH_TIME;

		// Token: 0x040050DC RID: 20700
		private static readonly IntPtr NativeFieldInfoPtr_PICKUP_RANGE;

		// Token: 0x040050DD RID: 20701
		private static readonly IntPtr NativeFieldInfoPtr_PICKUP_AREA_RADIUS;

		// Token: 0x040050DE RID: 20702
		private static readonly IntPtr NativeFieldInfoPtr__IsBaggingTrash_k__BackingField;

		// Token: 0x040050DF RID: 20703
		private static readonly IntPtr NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField;

		// Token: 0x040050E0 RID: 20704
		private static readonly IntPtr NativeFieldInfoPtr_PickupLookMask;

		// Token: 0x040050E1 RID: 20705
		private static readonly IntPtr NativeFieldInfoPtr_PickupAreaProjector;

		// Token: 0x040050E2 RID: 20706
		private static readonly IntPtr NativeFieldInfoPtr_RustleSound;

		// Token: 0x040050E3 RID: 20707
		private static readonly IntPtr NativeFieldInfoPtr_BagSound;

		// Token: 0x040050E4 RID: 20708
		private static readonly IntPtr NativeFieldInfoPtr__bagTrashTime;

		// Token: 0x040050E5 RID: 20709
		private static readonly IntPtr NativeFieldInfoPtr__baggedContainer;

		// Token: 0x040050E6 RID: 20710
		private static readonly IntPtr NativeFieldInfoPtr__pickupTrashTime;

		// Token: 0x040050E7 RID: 20711
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoveringTrash_Public_Static_get_Boolean_0;

		// Token: 0x040050E8 RID: 20712
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0;

		// Token: 0x040050E9 RID: 20713
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0;

		// Token: 0x040050EA RID: 20714
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0;

		// Token: 0x040050EB RID: 20715
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0;

		// Token: 0x040050EC RID: 20716
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040050ED RID: 20717
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040050EE RID: 20718
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040050EF RID: 20719
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0;

		// Token: 0x040050F0 RID: 20720
		private static readonly IntPtr NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0;

		// Token: 0x040050F1 RID: 20721
		private static readonly IntPtr NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0;

		// Token: 0x040050F2 RID: 20722
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0;

		// Token: 0x040050F3 RID: 20723
		private static readonly IntPtr NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0;

		// Token: 0x040050F4 RID: 20724
		private static readonly IntPtr NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0;

		// Token: 0x040050F5 RID: 20725
		private static readonly IntPtr NativeMethodInfoPtr_StartPickup_Private_Void_0;

		// Token: 0x040050F6 RID: 20726
		private static readonly IntPtr NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0;

		// Token: 0x040050F7 RID: 20727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
