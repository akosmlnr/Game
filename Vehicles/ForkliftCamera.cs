using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000500 RID: 1280
	public class ForkliftCamera : VehicleCamera
	{
		// Token: 0x06006F01 RID: 28417 RVA: 0x001EDFEC File Offset: 0x001EC1EC
		// Note: this type is marked as 'beforefieldinit'.
		static ForkliftCamera()
		{
			Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ForkliftCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr);
			ForkliftCamera.NativeFieldInfoPtr_forkCamPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, "forkCamPos");
			ForkliftCamera.NativeFieldInfoPtr_guidanceLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, "guidanceLight");
			ForkliftCamera.NativeFieldInfoPtr_forkliftCamActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, "forkliftCamActive");
			ForkliftCamera.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, 100677419);
			ForkliftCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, 100677420);
			ForkliftCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, 100677421);
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x001EE094 File Offset: 0x001EC294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221850, XrefRangeEnd = 221852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForkliftCamera.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x001EE0D0 File Offset: 0x001EC2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221852, XrefRangeEnd = 221866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForkliftCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x001EE10C File Offset: 0x001EC30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221866, XrefRangeEnd = 221867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForkliftCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForkliftCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x000344F0 File Offset: 0x000326F0
		public ForkliftCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x06006F06 RID: 28422 RVA: 0x001EE148 File Offset: 0x001EC348
		// (set) Token: 0x06006F07 RID: 28423 RVA: 0x000344F9 File Offset: 0x000326F9
		public unsafe Transform forkCamPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkCamPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkCamPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x06006F08 RID: 28424 RVA: 0x001EE178 File Offset: 0x001EC378
		// (set) Token: 0x06006F09 RID: 28425 RVA: 0x00034518 File Offset: 0x00032718
		public unsafe Light guidanceLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_guidanceLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_guidanceLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x06006F0A RID: 28426 RVA: 0x001EE1A8 File Offset: 0x001EC3A8
		// (set) Token: 0x06006F0B RID: 28427 RVA: 0x00034537 File Offset: 0x00032737
		public unsafe bool forkliftCamActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkliftCamActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkliftCamActive)) = value;
			}
		}

		// Token: 0x04004BE3 RID: 19427
		private static readonly IntPtr NativeFieldInfoPtr_forkCamPos;

		// Token: 0x04004BE4 RID: 19428
		private static readonly IntPtr NativeFieldInfoPtr_guidanceLight;

		// Token: 0x04004BE5 RID: 19429
		private static readonly IntPtr NativeFieldInfoPtr_forkliftCamActive;

		// Token: 0x04004BE6 RID: 19430
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04004BE7 RID: 19431
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04004BE8 RID: 19432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
