using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000525 RID: 1317
	public class PathPoint : MonoBehaviour
	{
		// Token: 0x06007300 RID: 29440 RVA: 0x001FABA4 File Offset: 0x001F8DA4
		// Note: this type is marked as 'beforefieldinit'.
		static PathPoint()
		{
			Il2CppClassPointerStore<PathPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPoint>.NativeClassPtr);
			PathPoint.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, "connections");
			PathPoint.NativeFieldInfoPtr_unique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, "unique");
			PathPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, 100677857);
		}

		// Token: 0x06007301 RID: 29441 RVA: 0x001FAC10 File Offset: 0x001F8E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226192, XrefRangeEnd = 226200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathPoint>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007302 RID: 29442 RVA: 0x00036627 File Offset: 0x00034827
		public PathPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x06007303 RID: 29443 RVA: 0x001FAC4C File Offset: 0x001F8E4C
		// (set) Token: 0x06007304 RID: 29444 RVA: 0x00036630 File Offset: 0x00034830
		public unsafe List<PathPoint> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x06007305 RID: 29445 RVA: 0x001FAC7C File Offset: 0x001F8E7C
		// (set) Token: 0x06007306 RID: 29446 RVA: 0x0003664F File Offset: 0x0003484F
		public unsafe bool unique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_unique);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_unique)) = value;
			}
		}

		// Token: 0x04004E8D RID: 20109
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x04004E8E RID: 20110
		private static readonly IntPtr NativeFieldInfoPtr_unique;

		// Token: 0x04004E8F RID: 20111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
