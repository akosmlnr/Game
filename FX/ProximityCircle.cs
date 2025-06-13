using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x0200041B RID: 1051
	public class ProximityCircle : MonoBehaviour
	{
		// Token: 0x06005672 RID: 22130 RVA: 0x00195F94 File Offset: 0x00194194
		// Note: this type is marked as 'beforefieldinit'.
		static ProximityCircle()
		{
			Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "ProximityCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr);
			ProximityCircle.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, "Circle");
			ProximityCircle.NativeFieldInfoPtr_enabledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, "enabledThisFrame");
			ProximityCircle.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100674121);
			ProximityCircle.NativeMethodInfoPtr_SetRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100674122);
			ProximityCircle.NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100674123);
			ProximityCircle.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100674124);
			ProximityCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100674125);
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x00196050 File Offset: 0x00194250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184587, XrefRangeEnd = 184589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x00196084 File Offset: 0x00194284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184590, RefRangeEnd = 184592, XrefRangeStart = 184589, XrefRangeEnd = 184590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRadius(float rad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rad;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x001960C4 File Offset: 0x001942C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 184595, RefRangeEnd = 184602, XrefRangeStart = 184592, XrefRangeEnd = 184595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x00196104 File Offset: 0x00194304
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 184603, RefRangeEnd = 184607, XrefRangeStart = 184602, XrefRangeEnd = 184603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x00196144 File Offset: 0x00194344
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProximityCircle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x000294F0 File Offset: 0x000276F0
		public ProximityCircle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06005679 RID: 22137 RVA: 0x00196180 File Offset: 0x00194380
		// (set) Token: 0x0600567A RID: 22138 RVA: 0x000294F9 File Offset: 0x000276F9
		public unsafe DecalProjector Circle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_Circle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_Circle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x0600567B RID: 22139 RVA: 0x001961B0 File Offset: 0x001943B0
		// (set) Token: 0x0600567C RID: 22140 RVA: 0x00029518 File Offset: 0x00027718
		public unsafe bool enabledThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_enabledThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_enabledThisFrame)) = value;
			}
		}

		// Token: 0x04003A7B RID: 14971
		private static readonly IntPtr NativeFieldInfoPtr_Circle;

		// Token: 0x04003A7C RID: 14972
		private static readonly IntPtr NativeFieldInfoPtr_enabledThisFrame;

		// Token: 0x04003A7D RID: 14973
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003A7E RID: 14974
		private static readonly IntPtr NativeMethodInfoPtr_SetRadius_Public_Void_Single_0;

		// Token: 0x04003A7F RID: 14975
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0;

		// Token: 0x04003A80 RID: 14976
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x04003A81 RID: 14977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
