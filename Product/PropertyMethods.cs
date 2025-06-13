using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005C1 RID: 1473
	public static class PropertyMethods : Il2CppSystem.Object
	{
		// Token: 0x0600800E RID: 32782 RVA: 0x00226810 File Offset: 0x00224A10
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyMethods()
		{
			Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr);
			PropertyMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679407);
			PropertyMethods.NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679408);
			PropertyMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679409);
		}

		// Token: 0x0600800F RID: 32783 RVA: 0x0022687C File Offset: 0x00224A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242317, XrefRangeEnd = 242318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this EProperty property)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref property;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008010 RID: 32784 RVA: 0x002268B4 File Offset: 0x00224AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242318, XrefRangeEnd = 242319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDescription(this EProperty property)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref property;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008011 RID: 32785 RVA: 0x002268EC File Offset: 0x00224AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242319, XrefRangeEnd = 242320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(this EProperty property)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref property;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008012 RID: 32786 RVA: 0x0003C99A File Offset: 0x0003AB9A
		public PropertyMethods(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005731 RID: 22321
		private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0;

		// Token: 0x04005732 RID: 22322
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0;

		// Token: 0x04005733 RID: 22323
		private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0;
	}
}
