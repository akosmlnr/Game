using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005BE RID: 1470
	public static class DrugTypeMethods : Il2CppSystem.Object
	{
		// Token: 0x06008005 RID: 32773 RVA: 0x00226684 File Offset: 0x00224884
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTypeMethods()
		{
			Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "DrugTypeMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr);
			DrugTypeMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr, 100679404);
			DrugTypeMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr, 100679405);
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x002266DC File Offset: 0x002248DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242315, XrefRangeEnd = 242316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this EDrugType property)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref property;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DrugTypeMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008007 RID: 32775 RVA: 0x00226714 File Offset: 0x00224914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242316, XrefRangeEnd = 242317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(this EDrugType property)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref property;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DrugTypeMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008008 RID: 32776 RVA: 0x0003C96D File Offset: 0x0003AB6D
		public DrugTypeMethods(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400571B RID: 22299
		private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0;

		// Token: 0x0400571C RID: 22300
		private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0;
	}
}
