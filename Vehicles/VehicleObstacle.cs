using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000513 RID: 1299
	public class VehicleObstacle : MonoBehaviour
	{
		// Token: 0x060071D7 RID: 29143 RVA: 0x001F79F4 File Offset: 0x001F5BF4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleObstacle()
		{
			Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleObstacle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr);
			VehicleObstacle.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "col");
			VehicleObstacle.NativeFieldInfoPtr_twoSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "twoSided");
			VehicleObstacle.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "type");
			VehicleObstacle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, 100677742);
		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x001F7A74 File Offset: 0x001F5C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225322, XrefRangeEnd = 225323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleObstacle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleObstacle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060071D9 RID: 29145 RVA: 0x00035B35 File Offset: 0x00033D35
		public VehicleObstacle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x060071DA RID: 29146 RVA: 0x001F7AB0 File Offset: 0x001F5CB0
		// (set) Token: 0x060071DB RID: 29147 RVA: 0x00035B3E File Offset: 0x00033D3E
		public unsafe Collider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x060071DC RID: 29148 RVA: 0x001F7AE0 File Offset: 0x001F5CE0
		// (set) Token: 0x060071DD RID: 29149 RVA: 0x00035B5D File Offset: 0x00033D5D
		public unsafe bool twoSided
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_twoSided);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_twoSided)) = value;
			}
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x060071DE RID: 29150 RVA: 0x001F7B08 File Offset: 0x001F5D08
		// (set) Token: 0x060071DF RID: 29151 RVA: 0x00035B78 File Offset: 0x00033D78
		public unsafe VehicleObstacle.EObstacleType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x04004DD4 RID: 19924
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04004DD5 RID: 19925
		private static readonly IntPtr NativeFieldInfoPtr_twoSided;

		// Token: 0x04004DD6 RID: 19926
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04004DD7 RID: 19927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB8 RID: 2744
		[OriginalName("Assembly-CSharp.dll", "", "EObstacleType")]
		public enum EObstacleType
		{
			// Token: 0x040090A5 RID: 37029
			Generic,
			// Token: 0x040090A6 RID: 37030
			TrafficLight
		}
	}
}
