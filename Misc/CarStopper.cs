using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x02000796 RID: 1942
	public class CarStopper : MonoBehaviour
	{
		// Token: 0x0600B81C RID: 47132 RVA: 0x002E05E8 File Offset: 0x002DE7E8
		// Note: this type is marked as 'beforefieldinit'.
		static CarStopper()
		{
			Il2CppClassPointerStore<CarStopper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "CarStopper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarStopper>.NativeClassPtr);
			CarStopper.NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "isActive");
			CarStopper.NativeFieldInfoPtr_blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "blocker");
			CarStopper.NativeFieldInfoPtr_Obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "Obstacle");
			CarStopper.NativeFieldInfoPtr_moveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "moveTime");
			CarStopper.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, 100686124);
			CarStopper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, 100686125);
		}

		// Token: 0x0600B81D RID: 47133 RVA: 0x002E0690 File Offset: 0x002DE890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315240, XrefRangeEnd = 315250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarStopper.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B81E RID: 47134 RVA: 0x002E06CC File Offset: 0x002DE8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarStopper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarStopper>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarStopper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B81F RID: 47135 RVA: 0x00059E40 File Offset: 0x00058040
		public CarStopper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600B820 RID: 47136 RVA: 0x002E0708 File Offset: 0x002DE908
		// (set) Token: 0x0600B821 RID: 47137 RVA: 0x00059E49 File Offset: 0x00058049
		public unsafe bool isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_isActive)) = value;
			}
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600B822 RID: 47138 RVA: 0x002E0730 File Offset: 0x002DE930
		// (set) Token: 0x0600B823 RID: 47139 RVA: 0x00059E64 File Offset: 0x00058064
		public unsafe Transform blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0600B824 RID: 47140 RVA: 0x002E0760 File Offset: 0x002DE960
		// (set) Token: 0x0600B825 RID: 47141 RVA: 0x00059E83 File Offset: 0x00058083
		public unsafe NavMeshObstacle Obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_Obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_Obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0600B826 RID: 47142 RVA: 0x002E0790 File Offset: 0x002DE990
		// (set) Token: 0x0600B827 RID: 47143 RVA: 0x00059EA2 File Offset: 0x000580A2
		public unsafe float moveTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_moveTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_moveTime)) = value;
			}
		}

		// Token: 0x04007C45 RID: 31813
		private static readonly IntPtr NativeFieldInfoPtr_isActive;

		// Token: 0x04007C46 RID: 31814
		private static readonly IntPtr NativeFieldInfoPtr_blocker;

		// Token: 0x04007C47 RID: 31815
		private static readonly IntPtr NativeFieldInfoPtr_Obstacle;

		// Token: 0x04007C48 RID: 31816
		private static readonly IntPtr NativeFieldInfoPtr_moveTime;

		// Token: 0x04007C49 RID: 31817
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007C4A RID: 31818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
