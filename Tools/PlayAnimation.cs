using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000568 RID: 1384
	public class PlayAnimation : MonoBehaviour
	{
		// Token: 0x06007976 RID: 31094 RVA: 0x00210E2C File Offset: 0x0020F02C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayAnimation()
		{
			Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PlayAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr);
			PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr, 100678691);
			PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr, 100678692);
			PlayAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr, 100678693);
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x00210E98 File Offset: 0x0020F098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235447, XrefRangeEnd = 235452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x00210ECC File Offset: 0x0020F0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235452, XrefRangeEnd = 235457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string animationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x00210F10 File Offset: 0x0020F110
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x0003945F File Offset: 0x0003765F
		public PlayAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040052E8 RID: 21224
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x040052E9 RID: 21225
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;

		// Token: 0x040052EA RID: 21226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
