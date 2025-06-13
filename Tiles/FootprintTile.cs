using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Building;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A5 RID: 421
	public class FootprintTile : MonoBehaviour
	{
		// Token: 0x06002230 RID: 8752 RVA: 0x000DE5E0 File Offset: 0x000DC7E0
		// Note: this type is marked as 'beforefieldinit'.
		static FootprintTile()
		{
			Il2CppClassPointerStore<FootprintTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "FootprintTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr);
			FootprintTile.NativeFieldInfoPtr_tileAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "tileAppearance");
			FootprintTile.NativeFieldInfoPtr_tileDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "tileDetector");
			FootprintTile.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "X");
			FootprintTile.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "Y");
			FootprintTile.NativeFieldInfoPtr_RequiredOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "RequiredOffset");
			FootprintTile.NativeFieldInfoPtr_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "Corners");
			FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "<MatchedStandardTile>k__BackingField");
			FootprintTile.NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667198);
			FootprintTile.NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667199);
			FootprintTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667200);
			FootprintTile.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667201);
			FootprintTile.NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667202);
			FootprintTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667203);
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x000DE714 File Offset: 0x000DC914
		// (set) Token: 0x06002232 RID: 8754 RVA: 0x000DE754 File Offset: 0x000DC954
		public unsafe Tile MatchedStandardTile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114197, XrefRangeEnd = 114198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x000DE798 File Offset: 0x000DC998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114198, XrefRangeEnd = 114200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootprintTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x000DE7D4 File Offset: 0x000DC9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Tile matchedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchedTile);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootprintTile.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x000DE824 File Offset: 0x000DCA24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114272, RefRangeEnd = 114273, XrefRangeStart = 114200, XrefRangeEnd = 114272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreCornerObstaclesBlocked(Tile proposedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(proposedTile);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x000DE874 File Offset: 0x000DCA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114273, XrefRangeEnd = 114281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00012F50 File Offset: 0x00011150
		public FootprintTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x000DE8B0 File Offset: 0x000DCAB0
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x00012F59 File Offset: 0x00011159
		public unsafe TileAppearance tileAppearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileAppearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileAppearance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileAppearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x000DE8E0 File Offset: 0x000DCAE0
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x00012F78 File Offset: 0x00011178
		public unsafe TileDetector tileDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x000DE910 File Offset: 0x000DCB10
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x00012F97 File Offset: 0x00011197
		public unsafe int X
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_X);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_X)) = value;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x000DE938 File Offset: 0x000DCB38
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x00012FB2 File Offset: 0x000111B2
		public unsafe int Y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Y)) = value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x000DE960 File Offset: 0x000DCB60
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x00012FCD File Offset: 0x000111CD
		public unsafe float RequiredOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_RequiredOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_RequiredOffset)) = value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x000DE988 File Offset: 0x000DCB88
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x00012FE8 File Offset: 0x000111E8
		public unsafe List<CornerObstacle> Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CornerObstacle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x000DE9B8 File Offset: 0x000DCBB8
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x00013007 File Offset: 0x00011207
		public unsafe Tile _MatchedStandardTile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeFieldInfoPtr_tileAppearance;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeFieldInfoPtr_tileDetector;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeFieldInfoPtr_RequiredOffset;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeFieldInfoPtr_Corners;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeFieldInfoPtr__MatchedStandardTile_k__BackingField;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
