using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Recording
{
	// Token: 0x02000518 RID: 1304
	[Serializable]
	public class DrivePath : ScriptableObject
	{
		// Token: 0x06007275 RID: 29301 RVA: 0x001F938C File Offset: 0x001F758C
		// Note: this type is marked as 'beforefieldinit'.
		static DrivePath()
		{
			Il2CppClassPointerStore<DrivePath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Recording", "DrivePath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrivePath>.NativeClassPtr);
			DrivePath.NativeFieldInfoPtr_fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrivePath>.NativeClassPtr, "fps");
			DrivePath.NativeFieldInfoPtr_keyframes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrivePath>.NativeClassPtr, "keyframes");
			DrivePath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivePath>.NativeClassPtr, 100677779);
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x001F93F8 File Offset: 0x001F75F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225543, XrefRangeEnd = 225551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrivePath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrivePath>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrivePath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x00036156 File Offset: 0x00034356
		public DrivePath(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x06007278 RID: 29304 RVA: 0x001F9434 File Offset: 0x001F7634
		// (set) Token: 0x06007279 RID: 29305 RVA: 0x0003615F File Offset: 0x0003435F
		public unsafe int fps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_fps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_fps)) = value;
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x0600727A RID: 29306 RVA: 0x001F945C File Offset: 0x001F765C
		// (set) Token: 0x0600727B RID: 29307 RVA: 0x0003617A File Offset: 0x0003437A
		public unsafe List<VehicleKeyFrame> keyframes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_keyframes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleKeyFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_keyframes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E30 RID: 20016
		private static readonly IntPtr NativeFieldInfoPtr_fps;

		// Token: 0x04004E31 RID: 20017
		private static readonly IntPtr NativeFieldInfoPtr_keyframes;

		// Token: 0x04004E32 RID: 20018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
