using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003C6 RID: 966
	public class TransitLineVisuals : MonoBehaviour
	{
		// Token: 0x06004AA1 RID: 19105 RVA: 0x0016D524 File Offset: 0x0016B724
		// Note: this type is marked as 'beforefieldinit'.
		static TransitLineVisuals()
		{
			Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitLineVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr);
			TransitLineVisuals.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, "Renderer");
			TransitLineVisuals.NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100672628);
			TransitLineVisuals.NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100672629);
			TransitLineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100672630);
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x0016D5A4 File Offset: 0x0016B7A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167598, RefRangeEnd = 167601, XrefRangeStart = 167597, XrefRangeEnd = 167598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSourcePosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x0016D5E4 File Offset: 0x0016B7E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167602, RefRangeEnd = 167604, XrefRangeStart = 167601, XrefRangeEnd = 167602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestinationPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x0016D624 File Offset: 0x0016B824
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitLineVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x00023CC4 File Offset: 0x00021EC4
		public TransitLineVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06004AA6 RID: 19110 RVA: 0x0016D660 File Offset: 0x0016B860
		// (set) Token: 0x06004AA7 RID: 19111 RVA: 0x00023CCD File Offset: 0x00021ECD
		public unsafe LineRenderer Renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitLineVisuals.NativeFieldInfoPtr_Renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitLineVisuals.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003251 RID: 12881
		private static readonly IntPtr NativeFieldInfoPtr_Renderer;

		// Token: 0x04003252 RID: 12882
		private static readonly IntPtr NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0;

		// Token: 0x04003253 RID: 12883
		private static readonly IntPtr NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0;

		// Token: 0x04003254 RID: 12884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
