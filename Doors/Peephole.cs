using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000447 RID: 1095
	public class Peephole : MonoBehaviour
	{
		// Token: 0x06005F56 RID: 24406 RVA: 0x001B9AA0 File Offset: 0x001B7CA0
		// Note: this type is marked as 'beforefieldinit'.
		static Peephole()
		{
			Il2CppClassPointerStore<Peephole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "Peephole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Peephole>.NativeClassPtr);
			Peephole.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "DoorAnim");
			Peephole.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "OpenSound");
			Peephole.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "CloseSound");
			Peephole.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100675531);
			Peephole.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100675532);
			Peephole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100675533);
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x001B9B48 File Offset: 0x001B7D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200425, RefRangeEnd = 200426, XrefRangeStart = 200421, XrefRangeEnd = 200425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x001B9B7C File Offset: 0x001B7D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200430, RefRangeEnd = 200431, XrefRangeStart = 200426, XrefRangeEnd = 200430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x001B9BB0 File Offset: 0x001B7DB0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Peephole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Peephole>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x0002CB61 File Offset: 0x0002AD61
		public Peephole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06005F5B RID: 24411 RVA: 0x001B9BEC File Offset: 0x001B7DEC
		// (set) Token: 0x06005F5C RID: 24412 RVA: 0x0002CB6A File Offset: 0x0002AD6A
		public unsafe Animation DoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_DoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06005F5D RID: 24413 RVA: 0x001B9C1C File Offset: 0x001B7E1C
		// (set) Token: 0x06005F5E RID: 24414 RVA: 0x0002CB89 File Offset: 0x0002AD89
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06005F5F RID: 24415 RVA: 0x001B9C4C File Offset: 0x001B7E4C
		// (set) Token: 0x06005F60 RID: 24416 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004142 RID: 16706
		private static readonly IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x04004143 RID: 16707
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04004144 RID: 16708
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04004145 RID: 16709
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04004146 RID: 16710
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004147 RID: 16711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
