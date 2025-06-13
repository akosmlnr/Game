using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A8 RID: 424
	public class ProceduralTile : MonoBehaviour
	{
		// Token: 0x0600226A RID: 8810 RVA: 0x000DF190 File Offset: 0x000DD390
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralTile()
		{
			Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "ProceduralTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr);
			ProceduralTile.NativeFieldInfoPtr_TileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "TileType");
			ProceduralTile.NativeFieldInfoPtr_ParentBuildableItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "ParentBuildableItem");
			ProceduralTile.NativeFieldInfoPtr_MatchedFootprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "MatchedFootprintTile");
			ProceduralTile.NativeFieldInfoPtr_Occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "Occupants");
			ProceduralTile.NativeFieldInfoPtr_OccupantTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "OccupantTiles");
			ProceduralTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100667223);
			ProceduralTile.NativeMethodInfoPtr_AddOccupant_Public_Void_FootprintTile_ProceduralGridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100667224);
			ProceduralTile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_FootprintTile_ProceduralGridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100667225);
			ProceduralTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100667226);
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x000DF274 File Offset: 0x000DD474
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x000DF2B0 File Offset: 0x000DD4B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114567, RefRangeEnd = 114568, XrefRangeStart = 114553, XrefRangeEnd = 114567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprint);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralTile.NativeMethodInfoPtr_AddOccupant_Public_Void_FootprintTile_ProceduralGridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x000DF304 File Offset: 0x000DD504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114580, RefRangeEnd = 114582, XrefRangeStart = 114568, XrefRangeEnd = 114580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprint);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralTile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_FootprintTile_ProceduralGridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x000DF358 File Offset: 0x000DD558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114582, XrefRangeEnd = 114597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00013150 File Offset: 0x00011350
		public ProceduralTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x000DF394 File Offset: 0x000DD594
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x00013159 File Offset: 0x00011359
		public unsafe ProceduralTile.EProceduralTileType TileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_TileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_TileType)) = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x000DF3BC File Offset: 0x000DD5BC
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x00013174 File Offset: 0x00011374
		public unsafe BuildableItem ParentBuildableItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_ParentBuildableItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_ParentBuildableItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x000DF3EC File Offset: 0x000DD5EC
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x00013193 File Offset: 0x00011393
		public unsafe FootprintTile MatchedFootprintTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_MatchedFootprintTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_MatchedFootprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x000DF41C File Offset: 0x000DD61C
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x000131B2 File Offset: 0x000113B2
		public unsafe List<ProceduralGridItem> Occupants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_Occupants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralGridItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_Occupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x000DF44C File Offset: 0x000DD64C
		// (set) Token: 0x06002279 RID: 8825 RVA: 0x000131D1 File Offset: 0x000113D1
		public unsafe List<FootprintTile> OccupantTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_OccupantTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootprintTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_OccupantTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeFieldInfoPtr_TileType;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeFieldInfoPtr_ParentBuildableItem;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeFieldInfoPtr_MatchedFootprintTile;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeFieldInfoPtr_Occupants;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeFieldInfoPtr_OccupantTiles;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr_AddOccupant_Public_Void_FootprintTile_ProceduralGridItem_0;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOccupant_Public_Void_FootprintTile_ProceduralGridItem_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008F1 RID: 2289
		[OriginalName("Assembly-CSharp.dll", "", "EProceduralTileType")]
		public enum EProceduralTileType
		{
			// Token: 0x040087AF RID: 34735
			Rack
		}
	}
}
