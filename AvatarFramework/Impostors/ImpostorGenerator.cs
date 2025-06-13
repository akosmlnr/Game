using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x02000621 RID: 1569
	public class ImpostorGenerator : MonoBehaviour
	{
		// Token: 0x0600895A RID: 35162 RVA: 0x002469D4 File Offset: 0x00244BD4
		// Note: this type is marked as 'beforefieldinit'.
		static ImpostorGenerator()
		{
			Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Impostors", "ImpostorGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr);
			ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "ImpostorCamera");
			ImpostorGenerator.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "Avatar");
			ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "GenerationQueue");
			ImpostorGenerator.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "output");
			ImpostorGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, 100680544);
		}

		// Token: 0x0600895B RID: 35163 RVA: 0x00246A68 File Offset: 0x00244C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255233, XrefRangeEnd = 255241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpostorGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpostorGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600895C RID: 35164 RVA: 0x0004114D File Offset: 0x0003F34D
		public ImpostorGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x0600895D RID: 35165 RVA: 0x00246AA4 File Offset: 0x00244CA4
		// (set) Token: 0x0600895E RID: 35166 RVA: 0x00041156 File Offset: 0x0003F356
		public unsafe Camera ImpostorCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x0600895F RID: 35167 RVA: 0x00246AD4 File Offset: 0x00244CD4
		// (set) Token: 0x06008960 RID: 35168 RVA: 0x00041175 File Offset: 0x0003F375
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x06008961 RID: 35169 RVA: 0x00246B04 File Offset: 0x00244D04
		// (set) Token: 0x06008962 RID: 35170 RVA: 0x00041194 File Offset: 0x0003F394
		public unsafe List<AvatarSettings> GenerationQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x06008963 RID: 35171 RVA: 0x00246B34 File Offset: 0x00244D34
		// (set) Token: 0x06008964 RID: 35172 RVA: 0x000411B3 File Offset: 0x0003F3B3
		public unsafe Texture2D output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D7D RID: 23933
		private static readonly IntPtr NativeFieldInfoPtr_ImpostorCamera;

		// Token: 0x04005D7E RID: 23934
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005D7F RID: 23935
		private static readonly IntPtr NativeFieldInfoPtr_GenerationQueue;

		// Token: 0x04005D80 RID: 23936
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04005D81 RID: 23937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
