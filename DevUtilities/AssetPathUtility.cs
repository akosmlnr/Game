using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046F RID: 1135
	public static class AssetPathUtility : Il2CppSystem.Object
	{
		// Token: 0x060061A5 RID: 24997 RVA: 0x0002DD39 File Offset: 0x0002BF39
		// Note: this type is marked as 'beforefieldinit'.
		static AssetPathUtility()
		{
			Il2CppClassPointerStore<AssetPathUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AssetPathUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetPathUtility>.NativeClassPtr);
			AssetPathUtility.NativeMethodInfoPtr_GetResourcesPath_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPathUtility>.NativeClassPtr, 100675848);
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x001C19F4 File Offset: 0x001BFBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203215, XrefRangeEnd = 203217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourcesPath(UnityEngine.Object selectedObject)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedObject);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AssetPathUtility.NativeMethodInfoPtr_GetResourcesPath_Public_Static_String_Object_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x0002DD72 File Offset: 0x0002BF72
		public AssetPathUtility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040042BC RID: 17084
		private static readonly System.IntPtr NativeMethodInfoPtr_GetResourcesPath_Public_Static_String_Object_0;
	}
}
