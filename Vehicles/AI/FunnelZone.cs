using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x0200051F RID: 1311
	public class FunnelZone : MonoBehaviour
	{
		// Token: 0x060072C9 RID: 29385 RVA: 0x001FA108 File Offset: 0x001F8308
		// Note: this type is marked as 'beforefieldinit'.
		static FunnelZone()
		{
			Il2CppClassPointerStore<FunnelZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "FunnelZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr);
			FunnelZone.NativeFieldInfoPtr_funnelZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "funnelZones");
			FunnelZone.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "col");
			FunnelZone.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "entryPoint");
			FunnelZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677804);
			FunnelZone.NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677805);
			FunnelZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677806);
			FunnelZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677807);
		}

		// Token: 0x060072CA RID: 29386 RVA: 0x001FA1C4 File Offset: 0x001F83C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225807, XrefRangeEnd = 225817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunnelZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x001FA200 File Offset: 0x001F8400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225817, XrefRangeEnd = 225835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FunnelZone GetFunnelZone(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunnelZone>(intPtr2) : null;
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x001FA240 File Offset: 0x001F8440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225835, XrefRangeEnd = 225847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x001FA274 File Offset: 0x001F8474
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunnelZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x00036478 File Offset: 0x00034678
		public FunnelZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x060072CF RID: 29391 RVA: 0x001FA2B0 File Offset: 0x001F84B0
		// (set) Token: 0x060072D0 RID: 29392 RVA: 0x00036481 File Offset: 0x00034681
		public unsafe static List<FunnelZone> funnelZones
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FunnelZone.NativeFieldInfoPtr_funnelZones, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunnelZone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FunnelZone.NativeFieldInfoPtr_funnelZones, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x060072D1 RID: 29393 RVA: 0x001FA2D8 File Offset: 0x001F84D8
		// (set) Token: 0x060072D2 RID: 29394 RVA: 0x00036493 File Offset: 0x00034693
		public unsafe BoxCollider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x060072D3 RID: 29395 RVA: 0x001FA308 File Offset: 0x001F8508
		// (set) Token: 0x060072D4 RID: 29396 RVA: 0x000364B2 File Offset: 0x000346B2
		public unsafe Transform entryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_entryPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_entryPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E6F RID: 20079
		private static readonly IntPtr NativeFieldInfoPtr_funnelZones;

		// Token: 0x04004E70 RID: 20080
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04004E71 RID: 20081
		private static readonly IntPtr NativeFieldInfoPtr_entryPoint;

		// Token: 0x04004E72 RID: 20082
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004E73 RID: 20083
		private static readonly IntPtr NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0;

		// Token: 0x04004E74 RID: 20084
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004E75 RID: 20085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
