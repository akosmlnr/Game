using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Building;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200075A RID: 1882
	public class FloorRack : GridItem
	{
		// Token: 0x0600AA77 RID: 43639 RVA: 0x002AB5F0 File Offset: 0x002A97F0
		// Note: this type is marked as 'beforefieldinit'.
		static FloorRack()
		{
			Il2CppClassPointerStore<FloorRack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "FloorRack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloorRack>.NativeClassPtr);
			FloorRack.NativeFieldInfoPtr_leg_BottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_BottomLeft");
			FloorRack.NativeFieldInfoPtr_leg_BottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_BottomRight");
			FloorRack.NativeFieldInfoPtr_leg_TopLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_TopLeft");
			FloorRack.NativeFieldInfoPtr_leg_TopRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_TopRight");
			FloorRack.NativeFieldInfoPtr_obs_BottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_BottomLeft");
			FloorRack.NativeFieldInfoPtr_obs_BottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_BottomRight");
			FloorRack.NativeFieldInfoPtr_obs_TopLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_TopLeft");
			FloorRack.NativeFieldInfoPtr_obs_TopRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_TopRight");
			FloorRack.NativeFieldInfoPtr_procTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "procTiles");
			FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted");
			FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted");
			FloorRack.NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684270);
			FloorRack.NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684271);
			FloorRack.NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684272);
			FloorRack.NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684273);
			FloorRack.NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684274);
			FloorRack.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684275);
			FloorRack.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684276);
			FloorRack.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684277);
			FloorRack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684278);
			FloorRack.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684279);
			FloorRack.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684280);
			FloorRack.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684281);
			FloorRack.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100684282);
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0600AA78 RID: 43640 RVA: 0x002AB800 File Offset: 0x002A9A00
		public unsafe virtual List<ProceduralTile> ProceduralTiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr2) : null;
			}
		}

		// Token: 0x0600AA79 RID: 43641 RVA: 0x002AB840 File Offset: 0x002A9A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296650, XrefRangeEnd = 296658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLegVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA7A RID: 43642 RVA: 0x002AB87C File Offset: 0x002A9A7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 296741, RefRangeEnd = 296745, XrefRangeStart = 296658, XrefRangeEnd = 296741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CockAndBalls(GameObject leg, CornerObstacle obs, int xOffset, int yOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leg);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yOffset;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA7B RID: 43643 RVA: 0x002AB8EC File Offset: 0x002A9AEC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 296755, RefRangeEnd = 296763, XrefRangeStart = 296745, XrefRangeEnd = 296755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorRack GetFloorRackFromOccupants(List<GridItem> occs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloorRack>(intPtr2) : null;
		}

		// Token: 0x0600AA7C RID: 43644 RVA: 0x002AB93C File Offset: 0x002A9B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296763, XrefRangeEnd = 296793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<FloorRack> GetSurroundingRacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FloorRack>>(intPtr2) : null;
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x002AB97C File Offset: 0x002A9B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296793, XrefRangeEnd = 296800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanShareTileWith(List<GridItem> obstacles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obstacles);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x002AB9D4 File Offset: 0x002A9BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296800, XrefRangeEnd = 296820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AA7F RID: 43647 RVA: 0x002ABA38 File Offset: 0x002A9C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296820, XrefRangeEnd = 296832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA80 RID: 43648 RVA: 0x002ABA84 File Offset: 0x002A9C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorRack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloorRack>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA81 RID: 43649 RVA: 0x002ABAC0 File Offset: 0x002A9CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296832, XrefRangeEnd = 296833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA82 RID: 43650 RVA: 0x002ABAFC File Offset: 0x002A9CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296833, XrefRangeEnd = 296834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA83 RID: 43651 RVA: 0x002ABB38 File Offset: 0x002A9D38
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA84 RID: 43652 RVA: 0x002ABB74 File Offset: 0x002A9D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296649, RefRangeEnd = 296650, XrefRangeStart = 296649, XrefRangeEnd = 296650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA85 RID: 43653 RVA: 0x00053C2D File Offset: 0x00051E2D
		public FloorRack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0600AA86 RID: 43654 RVA: 0x002ABBB0 File Offset: 0x002A9DB0
		// (set) Token: 0x0600AA87 RID: 43655 RVA: 0x00053C36 File Offset: 0x00051E36
		public unsafe Transform leg_BottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0600AA88 RID: 43656 RVA: 0x002ABBE0 File Offset: 0x002A9DE0
		// (set) Token: 0x0600AA89 RID: 43657 RVA: 0x00053C55 File Offset: 0x00051E55
		public unsafe Transform leg_BottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0600AA8A RID: 43658 RVA: 0x002ABC10 File Offset: 0x002A9E10
		// (set) Token: 0x0600AA8B RID: 43659 RVA: 0x00053C74 File Offset: 0x00051E74
		public unsafe Transform leg_TopLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0600AA8C RID: 43660 RVA: 0x002ABC40 File Offset: 0x002A9E40
		// (set) Token: 0x0600AA8D RID: 43661 RVA: 0x00053C93 File Offset: 0x00051E93
		public unsafe Transform leg_TopRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0600AA8E RID: 43662 RVA: 0x002ABC70 File Offset: 0x002A9E70
		// (set) Token: 0x0600AA8F RID: 43663 RVA: 0x00053CB2 File Offset: 0x00051EB2
		public unsafe CornerObstacle obs_BottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0600AA90 RID: 43664 RVA: 0x002ABCA0 File Offset: 0x002A9EA0
		// (set) Token: 0x0600AA91 RID: 43665 RVA: 0x00053CD1 File Offset: 0x00051ED1
		public unsafe CornerObstacle obs_BottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0600AA92 RID: 43666 RVA: 0x002ABCD0 File Offset: 0x002A9ED0
		// (set) Token: 0x0600AA93 RID: 43667 RVA: 0x00053CF0 File Offset: 0x00051EF0
		public unsafe CornerObstacle obs_TopLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0600AA94 RID: 43668 RVA: 0x002ABD00 File Offset: 0x002A9F00
		// (set) Token: 0x0600AA95 RID: 43669 RVA: 0x00053D0F File Offset: 0x00051F0F
		public unsafe CornerObstacle obs_TopRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x0600AA96 RID: 43670 RVA: 0x002ABD30 File Offset: 0x002A9F30
		// (set) Token: 0x0600AA97 RID: 43671 RVA: 0x00053D2E File Offset: 0x00051F2E
		public unsafe List<ProceduralTile> procTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_procTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_procTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0600AA98 RID: 43672 RVA: 0x002ABD60 File Offset: 0x002A9F60
		// (set) Token: 0x0600AA99 RID: 43673 RVA: 0x00053D4D File Offset: 0x00051F4D
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x0600AA9A RID: 43674 RVA: 0x002ABD88 File Offset: 0x002A9F88
		// (set) Token: 0x0600AA9B RID: 43675 RVA: 0x00053D68 File Offset: 0x00051F68
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007261 RID: 29281
		private static readonly IntPtr NativeFieldInfoPtr_leg_BottomLeft;

		// Token: 0x04007262 RID: 29282
		private static readonly IntPtr NativeFieldInfoPtr_leg_BottomRight;

		// Token: 0x04007263 RID: 29283
		private static readonly IntPtr NativeFieldInfoPtr_leg_TopLeft;

		// Token: 0x04007264 RID: 29284
		private static readonly IntPtr NativeFieldInfoPtr_leg_TopRight;

		// Token: 0x04007265 RID: 29285
		private static readonly IntPtr NativeFieldInfoPtr_obs_BottomLeft;

		// Token: 0x04007266 RID: 29286
		private static readonly IntPtr NativeFieldInfoPtr_obs_BottomRight;

		// Token: 0x04007267 RID: 29287
		private static readonly IntPtr NativeFieldInfoPtr_obs_TopLeft;

		// Token: 0x04007268 RID: 29288
		private static readonly IntPtr NativeFieldInfoPtr_obs_TopRight;

		// Token: 0x04007269 RID: 29289
		private static readonly IntPtr NativeFieldInfoPtr_procTiles;

		// Token: 0x0400726A RID: 29290
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400726B RID: 29291
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400726C RID: 29292
		private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0;

		// Token: 0x0400726D RID: 29293
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0;

		// Token: 0x0400726E RID: 29294
		private static readonly IntPtr NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0;

		// Token: 0x0400726F RID: 29295
		private static readonly IntPtr NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0;

		// Token: 0x04007270 RID: 29296
		private static readonly IntPtr NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0;

		// Token: 0x04007271 RID: 29297
		private static readonly IntPtr NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0;

		// Token: 0x04007272 RID: 29298
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04007273 RID: 29299
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x04007274 RID: 29300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007275 RID: 29301
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007276 RID: 29302
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007277 RID: 29303
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007278 RID: 29304
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
