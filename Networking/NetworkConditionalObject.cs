using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200038F RID: 911
	public class NetworkConditionalObject : MonoBehaviour
	{
		// Token: 0x0600462F RID: 17967 RVA: 0x0015B8C4 File Offset: 0x00159AC4
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkConditionalObject()
		{
			Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "NetworkConditionalObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr);
			NetworkConditionalObject.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, "condition");
			NetworkConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100671947);
			NetworkConditionalObject.NativeMethodInfoPtr_Check_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100671948);
			NetworkConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100671949);
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x0015B944 File Offset: 0x00159B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160334, XrefRangeEnd = 160369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x0015B978 File Offset: 0x00159B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160369, XrefRangeEnd = 160372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr_Check_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x0015B9AC File Offset: 0x00159BAC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkConditionalObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x00022153 File Offset: 0x00020353
		public NetworkConditionalObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06004634 RID: 17972 RVA: 0x0015B9E8 File Offset: 0x00159BE8
		// (set) Token: 0x06004635 RID: 17973 RVA: 0x0002215C File Offset: 0x0002035C
		public unsafe NetworkConditionalObject.ECondition condition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkConditionalObject.NativeFieldInfoPtr_condition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkConditionalObject.NativeFieldInfoPtr_condition)) = value;
			}
		}

		// Token: 0x04002EFC RID: 12028
		private static readonly IntPtr NativeFieldInfoPtr_condition;

		// Token: 0x04002EFD RID: 12029
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002EFE RID: 12030
		private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_0;

		// Token: 0x04002EFF RID: 12031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009B4 RID: 2484
		[OriginalName("Assembly-CSharp.dll", "", "ECondition")]
		public enum ECondition
		{
			// Token: 0x04008BBF RID: 35775
			All,
			// Token: 0x04008BC0 RID: 35776
			HostOnly
		}
	}
}
