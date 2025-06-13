using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000522 RID: 1314
	public class RoadPath : Il2CppSystem.Object
	{
		// Token: 0x060072EE RID: 29422 RVA: 0x001FA958 File Offset: 0x001F8B58
		// Note: this type is marked as 'beforefieldinit'.
		static RoadPath()
		{
			Il2CppClassPointerStore<RoadPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "RoadPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPath>.NativeClassPtr);
			RoadPath.NativeFieldInfoPtr_vectorPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPath>.NativeClassPtr, "vectorPath");
			RoadPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPath>.NativeClassPtr, 100677855);
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x001FA9B0 File Offset: 0x001F8BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226184, XrefRangeEnd = 226192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadPath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadPath>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x00036550 File Offset: 0x00034750
		public RoadPath(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x060072F1 RID: 29425 RVA: 0x001FA9EC File Offset: 0x001F8BEC
		// (set) Token: 0x060072F2 RID: 29426 RVA: 0x00036559 File Offset: 0x00034759
		public unsafe List<PathPoint> vectorPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadPath.NativeFieldInfoPtr_vectorPath);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathPoint>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadPath.NativeFieldInfoPtr_vectorPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E86 RID: 20102
		private static readonly System.IntPtr NativeFieldInfoPtr_vectorPath;

		// Token: 0x04004E87 RID: 20103
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
