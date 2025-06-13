using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065C RID: 1628
	public class EyeLidOverlaySetter : MonoBehaviour
	{
		// Token: 0x06008EF3 RID: 36595 RVA: 0x0025709C File Offset: 0x0025529C
		// Note: this type is marked as 'beforefieldinit'.
		static EyeLidOverlaySetter()
		{
			Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "EyeLidOverlaySetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr);
			EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, "OpenOverride");
			EyeLidOverlaySetter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100681144);
			EyeLidOverlaySetter.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100681145);
			EyeLidOverlaySetter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100681146);
			EyeLidOverlaySetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100681147);
		}

		// Token: 0x06008EF4 RID: 36596 RVA: 0x00257130 File Offset: 0x00255330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260878, XrefRangeEnd = 260885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EF5 RID: 36597 RVA: 0x00257164 File Offset: 0x00255364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260885, XrefRangeEnd = 260892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EF6 RID: 36598 RVA: 0x00257198 File Offset: 0x00255398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260892, XrefRangeEnd = 260900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EF7 RID: 36599 RVA: 0x002571CC File Offset: 0x002553CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77482, RefRangeEnd = 77486, XrefRangeStart = 77482, XrefRangeEnd = 77486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeLidOverlaySetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EF8 RID: 36600 RVA: 0x000444CB File Offset: 0x000426CB
		public EyeLidOverlaySetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x00257208 File Offset: 0x00255408
		// (set) Token: 0x06008EFA RID: 36602 RVA: 0x000444D4 File Offset: 0x000426D4
		public unsafe float OpenOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride)) = value;
			}
		}

		// Token: 0x040060E8 RID: 24808
		private static readonly IntPtr NativeFieldInfoPtr_OpenOverride;

		// Token: 0x040060E9 RID: 24809
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040060EA RID: 24810
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040060EB RID: 24811
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040060EC RID: 24812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
