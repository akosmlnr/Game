using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200056C RID: 1388
	public class RemoveChildColliders : MonoBehaviour
	{
		// Token: 0x060079B4 RID: 31156 RVA: 0x00211934 File Offset: 0x0020FB34
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveChildColliders()
		{
			Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RemoveChildColliders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr);
			RemoveChildColliders.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr, 100678711);
			RemoveChildColliders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr, 100678712);
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x0021198C File Offset: 0x0020FB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235698, XrefRangeEnd = 235706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveChildColliders.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x002119C0 File Offset: 0x0020FBC0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveChildColliders() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveChildColliders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079B7 RID: 31159 RVA: 0x00039661 File Offset: 0x00037861
		public RemoveChildColliders(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400530D RID: 21261
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400530E RID: 21262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
