using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000572 RID: 1394
	public class SetTerrainObstacles : MonoBehaviour
	{
		// Token: 0x060079E5 RID: 31205 RVA: 0x00212194 File Offset: 0x00210394
		// Note: this type is marked as 'beforefieldinit'.
		static SetTerrainObstacles()
		{
			Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetTerrainObstacles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr);
			SetTerrainObstacles.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "Bounds");
			SetTerrainObstacles.NativeFieldInfoPtr_Obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "Obstacle");
			SetTerrainObstacles.NativeFieldInfoPtr_terrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "terrain");
			SetTerrainObstacles.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "width");
			SetTerrainObstacles.NativeFieldInfoPtr_lenght = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "lenght");
			SetTerrainObstacles.NativeFieldInfoPtr_hight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "hight");
			SetTerrainObstacles.NativeFieldInfoPtr_isError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "isError");
			SetTerrainObstacles.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, 100678726);
			SetTerrainObstacles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, 100678727);
		}

		// Token: 0x060079E6 RID: 31206 RVA: 0x00212278 File Offset: 0x00210478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235795, XrefRangeEnd = 235945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTerrainObstacles.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x002122AC File Offset: 0x002104AC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTerrainObstacles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTerrainObstacles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x000397CB File Offset: 0x000379CB
		public SetTerrainObstacles(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x060079E9 RID: 31209 RVA: 0x002122E8 File Offset: 0x002104E8
		// (set) Token: 0x060079EA RID: 31210 RVA: 0x000397D4 File Offset: 0x000379D4
		public unsafe BoxCollider Bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Bounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Bounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x060079EB RID: 31211 RVA: 0x00212318 File Offset: 0x00210518
		// (set) Token: 0x060079EC RID: 31212 RVA: 0x000397F3 File Offset: 0x000379F3
		public unsafe Il2CppStructArray<TreeInstance> Obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TreeInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x060079ED RID: 31213 RVA: 0x00212348 File Offset: 0x00210548
		// (set) Token: 0x060079EE RID: 31214 RVA: 0x00039812 File Offset: 0x00037A12
		public unsafe Terrain terrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_terrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_terrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x060079EF RID: 31215 RVA: 0x00212378 File Offset: 0x00210578
		// (set) Token: 0x060079F0 RID: 31216 RVA: 0x00039831 File Offset: 0x00037A31
		public unsafe float width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x060079F1 RID: 31217 RVA: 0x002123A0 File Offset: 0x002105A0
		// (set) Token: 0x060079F2 RID: 31218 RVA: 0x0003984C File Offset: 0x00037A4C
		public unsafe float lenght
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_lenght);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_lenght)) = value;
			}
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x060079F3 RID: 31219 RVA: 0x002123C8 File Offset: 0x002105C8
		// (set) Token: 0x060079F4 RID: 31220 RVA: 0x00039867 File Offset: 0x00037A67
		public unsafe float hight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_hight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_hight)) = value;
			}
		}

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x060079F5 RID: 31221 RVA: 0x002123F0 File Offset: 0x002105F0
		// (set) Token: 0x060079F6 RID: 31222 RVA: 0x00039882 File Offset: 0x00037A82
		public unsafe bool isError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_isError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_isError)) = value;
			}
		}

		// Token: 0x04005327 RID: 21287
		private static readonly IntPtr NativeFieldInfoPtr_Bounds;

		// Token: 0x04005328 RID: 21288
		private static readonly IntPtr NativeFieldInfoPtr_Obstacle;

		// Token: 0x04005329 RID: 21289
		private static readonly IntPtr NativeFieldInfoPtr_terrain;

		// Token: 0x0400532A RID: 21290
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x0400532B RID: 21291
		private static readonly IntPtr NativeFieldInfoPtr_lenght;

		// Token: 0x0400532C RID: 21292
		private static readonly IntPtr NativeFieldInfoPtr_hight;

		// Token: 0x0400532D RID: 21293
		private static readonly IntPtr NativeFieldInfoPtr_isError;

		// Token: 0x0400532E RID: 21294
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400532F RID: 21295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
