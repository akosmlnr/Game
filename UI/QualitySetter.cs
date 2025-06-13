using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000647 RID: 1607
	public class QualitySetter : MonoBehaviour
	{
		// Token: 0x06008CBE RID: 36030 RVA: 0x002504EC File Offset: 0x0024E6EC
		// Note: this type is marked as 'beforefieldinit'.
		static QualitySetter()
		{
			Il2CppClassPointerStore<QualitySetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "QualitySetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr);
			QualitySetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680880);
			QualitySetter.NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680881);
			QualitySetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680882);
			QualitySetter.NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680883);
		}

		// Token: 0x06008CBF RID: 36031 RVA: 0x0025056C File Offset: 0x0024E76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258199, XrefRangeEnd = 258212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CC0 RID: 36032 RVA: 0x002505A0 File Offset: 0x0024E7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258212, XrefRangeEnd = 258221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuality(int quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CC1 RID: 36033 RVA: 0x002505E0 File Offset: 0x0024E7E0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualitySetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CC2 RID: 36034 RVA: 0x0025061C File Offset: 0x0024E81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258221, XrefRangeEnd = 258230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__0_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CC3 RID: 36035 RVA: 0x00043106 File Offset: 0x00041306
		public QualitySetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005F82 RID: 24450
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005F83 RID: 24451
		private static readonly IntPtr NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0;

		// Token: 0x04005F84 RID: 24452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005F85 RID: 24453
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0;
	}
}
